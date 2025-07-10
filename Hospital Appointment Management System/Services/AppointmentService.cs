using Hospital_Appointment_Management_System.Models;
using Hospital_Appointment_Management_System.Models.Entities;
using Hospital_Appointment_Management_System.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Appointment_Management_System.Services
{
    public class AppointmentService
    {
        private readonly IRepository<Appointment> _appointmentRepository;

      
        public AppointmentService(IRepository<Appointment> appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsByDoctorId(int DoctorId)
        {
            var DoctorAppointments = await _appointmentRepository.GetAllAsync();
            return DoctorAppointments.Where(a => a.DoctorId == DoctorId);
        }

      /*  public async Task<IEnumerable<Appointment>> GetAppointmentsByPatientId(int patientId)
        {
            var appointments = await _appointmentRepository.GetAllAsync();
            return appointments.Where(a => a.
            UserId == patientId);
        }
        */

        public async Task<bool> TimeAvailable(DateTime requestedTime)
        {
            var appointments = await _appointmentRepository.GetAllAsync();
            return !appointments.Any(a => a.AppointmentDate == requestedTime);
        }

      
        public async Task<Appointment> CreateAppointment(Appointment appointment)
        {
            
            if (await TimeAvailable(appointment.AppointmentDate))
            {
                await _appointmentRepository.AddAsync(appointment);
                await _appointmentRepository.SaveAsync();
                return appointment;
            }

            return null; 
        }

      
        public async Task UpdateAppointment(Appointment appointment)
        {
            _appointmentRepository.Update(appointment);
            await _appointmentRepository.SaveAsync();
        
        }
        /*
        public async Task DeleteAppointment(int appointmentId)
        {
            var appointment = await _appointmentRepository.GetByIdAsync(appointmentId);
            if (appointment != null)
            {
                _appointmentRepository.Delete(appointment);
                await _appointmentRepository.SaveAsync();
            }
        }
        */
    }
}
