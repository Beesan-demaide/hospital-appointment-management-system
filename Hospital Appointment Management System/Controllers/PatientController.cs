using Hospital_Appointment_Management_System.Dto;
using Hospital_Appointment_Management_System.Models.Entities;
using Hospital_Appointment_Management_System.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Hospital_Appointment_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly PatientService _patientService;

        public PatientController(PatientService patientService)
        {
            _patientService = patientService;
        }

        [Authorize(Roles = "Patient")]
        [HttpPut("edit")]
        public async Task<IActionResult> EditProfile([FromBody] EditProfileDto editProfileDto)
        {
            var userId = int.Parse(User.FindFirst("UserId").Value);
            var updatedUser = await _patientService.EditProfile(userId, editProfileDto);

            if (updatedUser == null)
            {
                return BadRequest("Invalid old password or user not found.");
            }

            return Ok(updatedUser);
        }

        [Authorize(Roles = "Patient")]
        [HttpPost("book")]
        public async Task<IActionResult> BookAppointment([FromBody] BookAppointmentDto appointmentDto)
        {
            var patientId = int.Parse(User.FindFirst("UserId").Value);
            try
            {
                var result = await _patientService.BookAppointmentAsync(appointmentDto.ScheduleId, patientId);
                if (result == "Appointment booked successfully.")
                {
                    return Ok(result);
                }

                return BadRequest(result); 
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        /*[HttpPost("book")]

        public async Task<IActionResult> BookAppointment([FromBody] BookAppointmentDto appointmentDto)
        {
            var patientId = int.Parse(User.FindFirst("UserId").Value);
            try
            {
                var appointment = await _patientService.BookAppointment(patientId, appointmentDto.DoctorId, appointmentDto.AppointmentDate);
                return Ok(appointment);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        */
        [Authorize(Roles = "Patient")]
        [HttpPut("reschedule/{appointmentId}")]
        public async Task<IActionResult> RescheduleAppointment(int appointmentId, [FromBody] RescheduleAppointmentDto rescheduleDto)
        {
            var patientId = int.Parse(User.FindFirst("UserId").Value);
            try
            {
                var updatedAppointment = await _patientService.RescheduleAppointment(patientId, appointmentId, rescheduleDto.NewAppointmentDate);
                return Ok(updatedAppointment);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Patient")]
        [HttpDelete("cancel/{appointmentId}")]
        public async Task<IActionResult> CancelAppointment(int appointmentId)
        {
            var patientId = int.Parse(User.FindFirst("UserId").Value);  

            try
            {
                var result = await _patientService.CancelAppointment(patientId, appointmentId); 

                if (!result)
                {
                    return NotFound("Appointment not found or not owned by the patient");
                }

                return Ok("Appointment has been successfully canceled");
            }
            catch (Exception ex)
            {
                return BadRequest($"rror : {ex.Message}");
            }
        }


    }
}
        /*
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetPatients()
        {
            var patients = await _patientService.GetPatients();
            if (patients == null)
            {
                return NotFound("No patients found.");
            }
            return Ok(patients);
        }

        // Book an appointment for a patient
        [HttpPost("{patientId}/appointments")]
        public async Task<ActionResult<Appointment>> BookAppointment(int patientId, [FromBody] Appointment appointment)
        {
            if (appointment == null)
            {
                return BadRequest("Appointment data is missing.");
            }

            var bookedAppointment = await _patientService.BookAppointment(patientId, appointment);
            if (bookedAppointment == null)
            {
                return BadRequest("Appointment cannot be booked. The slot may be already taken or the patient is invalid.");
            }

            return CreatedAtAction(nameof(GetAppointmentsForPatient), new { patientId = patientId }, bookedAppointment);
        }

        // Get all appointments for a patient
        [HttpGet("{patientId}/appointments")]
        public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointmentsForPatient(int patientId)
        {
            var appointments = await _patientService.GetAppointmentsForPatient(patientId);
            if (appointments == null)
            {
                return NotFound($"No appointments found for patient with ID {patientId}.");
            }
            return Ok(appointments);
        }
    }
}
*/