
/*using Hospital_Appointment_Management_System.Models;
using Hospital_Appointment_Management_System.Models.Entities;
using Hospital_Appointment_Management_System.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital_Appointment_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppointmentService _appointmentService;

        public AppointmentsController(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        // GET: api/appointments/{patientId}
        [HttpGet("{patientId}")]
        public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointments(int patientId)
        {
            var appointments = await _appointmentService.GetAppointmentsByPatientId(patientId);
            return Ok(appointments);
        }

        // POST: api/appointments
        [HttpPost]
        public async Task<ActionResult<Appointment>> PostAppointment(Appointment appointment)
        {
            var createdAppointment = await _appointmentService.CreateAppointment(appointment);
            if (createdAppointment == null)
            {
                return BadRequest("The time slot is not available.");
            }

            return CreatedAtAction(nameof(GetAppointments), new { patientId = createdAppointment.Id }, createdAppointment);
        }

        // PUT: api/appointments/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppointment(int id, Appointment appointment)
        {
            if (id != appointment.AppointmentId)
            {
                return BadRequest();
            }

            await _appointmentService.UpdateAppointment(appointment);
            return NoContent();
        }

        // DELETE: api/appointments/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            await _appointmentService.DeleteAppointment(id);
            return NoContent();
        }
    }
}
*/