
using Hospital_Appointment_Management_System.Dto;
using Hospital_Appointment_Management_System.Models.Entities;
using Hospital_Appointment_Management_System.Repositories;
using Hospital_Appointment_Management_System.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;


namespace Hospital_Appointment_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorService _doctorService;
        private readonly IRepository<User> _userRepository;


        public DoctorController(DoctorService doctorService, IRepository<User> userRepository)
        {
            _doctorService = doctorService;
            _userRepository = userRepository;
        }
        [Authorize(Roles = "Doctor")]
        [HttpPost("SetSchedule")]
        public async Task<IActionResult> SetSchedule([FromBody] ScheduleDTO scheduleDTO)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            if (string.IsNullOrEmpty(userId) || !int.TryParse(userId, out int parsedUserId))
            {
                return Unauthorized("Invalid user token.");
            }            var user = await _userRepository.GetByIdAsync(parsedUserId);
            if (user == null || user.DoctorId == null)
            {
                return Unauthorized("User is not associated with a doctor profile");
            }
            var doctorId = user.DoctorId.Value;

            var schedule = await _doctorService.Setavailability(doctorId, scheduleDTO.StartTime, scheduleDTO.EndTime, scheduleDTO.IsAvailable);

            if (schedule == null)
            {
                return BadRequest("Doctor not found.");
            }

            return Ok(schedule);
        }

        [HttpPut("{doctorId}/UpdateSchedule")]
        public async Task<IActionResult> UpdateSchedule(int doctorId,[FromBody]Schedule schedule)
        {
            var updateSchedule = await _doctorService.Updateavailability(doctorId,schedule);

            if (updateSchedule == null)
            {
                return NotFound("Doctor or Schedule Not Found");
            }

            return Ok(updateSchedule);
        }

        [HttpGet("Search")]
        public async Task<IActionResult> SearchDoctors([FromQuery] string specialty)
        {
            var doctors = await _doctorService.SearchDoctors(specialty);
            if (doctors == null || !doctors.Any())
            {
                return NotFound("No doctors found based on your search");
            }

            return Ok(doctors);
        }
    }
}


