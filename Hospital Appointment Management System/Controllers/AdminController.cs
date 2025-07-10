using Hospital_Appointment_Management_System.Dto;
using Hospital_Appointment_Management_System.Models;
using Hospital_Appointment_Management_System.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly HospitalDbContext _dbcontext;
    private readonly IConfiguration _configuration;

    public AdminController(HospitalDbContext dbcontext, IConfiguration configuration)
    {
        _dbcontext = dbcontext;
        _configuration = configuration;
    }
    
    
    [Authorize(Roles = "Admin")]
    [HttpPost("AddNew-doctor")]
    public async Task<IActionResult> AddDoctor([FromBody] DoctorRegistrationDTO model)
    {
        if (model == null || model.Doctor == null)
        {
            return BadRequest("Invalid doctor data");
        }

        var doctor = model.Doctor;

        var role = await _dbcontext.Roles.FirstOrDefaultAsync(r => r.Name == "Doctor");
        if (role == null)
        {
            role = new Role { Name = "Doctor" };
            _dbcontext.Roles.Add(role);
            await _dbcontext.SaveChangesAsync();
        }

        var passwordHasher = new PasswordHasher<User>();
        var hashedPassword = passwordHasher.HashPassword(null, model.Password);

        var user = new User
        {
            UserName = doctor.Name,
            Email = $"{doctor.Name}@hospital.com",
            PasswordHash = hashedPassword,
            RoleId = role.Id
        };

        _dbcontext.Users.Add(user);
        await _dbcontext.SaveChangesAsync(); 
        _dbcontext.Doctors.Add(doctor);
        await _dbcontext.SaveChangesAsync();

     
        user.DoctorId = doctor.Id;
        await _dbcontext.SaveChangesAsync(); 

        return Ok("Doctor added successfully");
    }


    [HttpGet("specialties")]
    public async Task<IActionResult> GetSpecialties()
    {
        var specialties = await _dbcontext.Doctors
                                          .Select(d => d.Specialty)
                                          .Distinct().ToListAsync();

        if (specialties == null || !specialties.Any())
        {
            return NotFound("No specialties found.");
        }

        return Ok(specialties);
    }

    [HttpGet("roles")]
    public async Task<IActionResult> GetRoles()
    {
        var roles = await _dbcontext.Roles.Select(r => r.Name).ToListAsync();
        return Ok(roles);
    }
    [HttpGet("available-schedules")]
    public async Task<IActionResult> GetAvailableSchedules([FromQuery] string specialty, [FromQuery] DateTime appointmentDate)
    {
        var schedules = await _dbcontext.Schedules
            .Where(s => s.IsAvailable && s.StartTime.Date == appointmentDate.Date)
            .Include(s => s.Doctor) 
            .Where(s => s.Doctor.Specialty == specialty) 
            .ToListAsync();

        var result = schedules.Select(s => new
        {
            s.Id,
            DoctorName = s.Doctor.Name, 
            s.StartTime,
            s.EndTime,
            s.IsAvailable
        }).ToList();

        return Ok(result);
    }

}
