using Hospital_Appointment_Management_System.Models.Entities;
using Hospital_Appointment_Management_System.Repositories;
using Hospital_Appointment_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Hospital_Appointment_Management_System.Dto;
using Microsoft.EntityFrameworkCore;


namespace Hospital_Appointment_Management_System.Services
{
    public class DoctorService
    {

        private readonly IRepository<Doctor> _doctorRepository;
        private readonly IRepository<Appointment> _appointmentRepository;
        private readonly IRepository<Schedule> _scheduleRepository;
        public DoctorService(IRepository<Doctor> doctorRepository, IRepository<Appointment> appointmentRepository,
            IRepository<Schedule> scheduleRepository)
        {
            _doctorRepository = doctorRepository;
            _appointmentRepository = appointmentRepository;
            _scheduleRepository = scheduleRepository;
        }

        public async Task<Schedule> Setavailability(int doctorId, DateTime startTime, DateTime endTime, bool isAvailable)
        {
            var doctor = await _doctorRepository.GetByIdAsync(doctorId);
            if (doctor == null)
            {
                return null;
            }

            if (startTime >= endTime)
            {
                throw new ArgumentException("Start time must be before end time.");
            }

            var currentTime = DateTime.Now;
            if (startTime < currentTime || endTime < currentTime)
            {
                throw new ArgumentException("Start time and end time cannot be in the past.");
            }

            var newSchedule = new Schedule
            {
                DoctorId = doctorId,
                StartTime = startTime,
                EndTime = endTime,
                IsAvailable = isAvailable
            };

            await _scheduleRepository.AddAsync(newSchedule);
            await _scheduleRepository.SaveAsync();
            return newSchedule;
        }

        public async Task<Schedule> Updateavailability(int doctorId, Schedule schedule)
        {
            var doctor = await _doctorRepository.GetByIdAsync(doctorId);
            if (doctor == null)
            {
                return null;
            }

            var oldschedule = await _scheduleRepository.GetByIdAsync(schedule.Id);
            if (oldschedule == null || schedule.DoctorId != doctorId)
            {
                return null;
            }

            oldschedule.IsAvailable = schedule.IsAvailable;
            oldschedule.StartTime = schedule.StartTime;
            oldschedule.EndTime = schedule.EndTime;

            await _scheduleRepository.AddAsync(oldschedule);
            await _scheduleRepository.SaveAsync();
            return schedule;
        }
             public async Task<IEnumerable<Doctor>> SearchDoctors(string specialty)
                {
                    var query = _doctorRepository.GetAllAsync(); 
                    var doctors = await query; 

                    if (!string.IsNullOrEmpty(specialty))
                    {
                        doctors = doctors.Where(d => d.Specialty.Contains(specialty)).ToList();
                    }

            /*if (isAvailable.HasValue)
            {
                doctors = doctors.Where(d => d.Schedules.Any(s => s.IsAvailable == isAvailable.Value)).ToList();
            }*/
            return doctors;
                }
    }


}


