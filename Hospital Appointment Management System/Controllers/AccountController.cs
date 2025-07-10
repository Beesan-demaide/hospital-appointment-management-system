using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

using System.Text;
using Microsoft.EntityFrameworkCore;
using Hospital_Appointment_Management_System.Models.Auth;
using Microsoft.AspNetCore.Identity;

[Route("api/auth")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly HospitalDbContext _context;
    private readonly IConfiguration _configuration;

    public AccountController(HospitalDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterModel model)
    {
        var existingUser = await _context.Users
            .FirstOrDefaultAsync(u => u.UserName == model.UserName || u.Email == model.Email);

        if (existingUser != null)
            return BadRequest(new{message = "A user with this username or email already exists" });

        var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == model.Role);
        if (role == null)
            return BadRequest(new { message = "Role not found" });


        var passwordHasher = new PasswordHasher<User>();

        var user = new User
        {
            UserName = model.UserName,
            Email = model.Email,
            PasswordHash = passwordHasher.HashPassword(null,model.Password),
            RoleId = role.Id
        };

       
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        //var token = GenerateJwtToken(user);
        return Ok("Done");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginModel model)
    {
        var user = await _context.Users
            .Include(ur => ur.Role)
            .FirstOrDefaultAsync(u => u.UserName == model.UserName);

        if (user == null)
            return Unauthorized(new { message = "Invalid username" });

        var passwordHasher = new PasswordHasher<User>();
        var result = passwordHasher.VerifyHashedPassword(null, user.PasswordHash, model.Password);

        if (result == PasswordVerificationResult.Failed)
        {
            return Unauthorized(new { message = "Invalid password" });
        }

        var token = GenerateJwtToken(user);
        var roles = new List<string> { user.Role.Name }; 

        return Ok(new { token,roles});
    }

    
    private string GenerateJwtToken(User user)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            //new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email),
             new Claim("UserId", user.Id.ToString()),
             
        };
        
            claims.Add(new Claim(ClaimTypes.Role, user.Role.Name));
        
        var token = new JwtSecurityToken(
            _configuration["Jwt:Issuer"],
            _configuration["Jwt:Audience"],
            claims,
            expires: DateTime.UtcNow.AddHours(2),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
    [HttpGet("{userId}/DoctorId")]
    public async Task<int?> GetDoctorIdFromUserId(string userId)
    {
        var user = await _context.Users.Include(u => u.Doctor).FirstOrDefaultAsync(u => u.Id.ToString() == userId);

        if (user != null && user.Doctor != null)
        {
            return user.Doctor.Id;  
        }

        return null; 
    }

}
