
using Hospital_Appointment_Management_System.Dto;
using Hospital_Appointment_Management_System.Models.Entities;
using Hospital_Appointment_Management_System.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Runtime.CompilerServices;


public class PatientService
{
    private readonly IRepository<User> _userRepository;
    private readonly IRepository<Appointment> _appointmentRepository;
    private readonly IRepository<Doctor> _doctorRepository;
    private readonly IRepository<Schedule> _scheduleRepository;


    public PatientService(IRepository<Doctor> doctorRepository,IRepository<User> userRepository, IRepository<Appointment> appointmentRepository, IRepository<Schedule> scheduleRepository)
    {
        _userRepository = userRepository;
        _appointmentRepository = appointmentRepository;
        _doctorRepository = doctorRepository;
        _scheduleRepository = scheduleRepository;
    }

    public async Task<User> EditProfile(int UserId, EditProfileDto editProfileDto)
    {
        var Patient = await _userRepository.GetByIdAsync(UserId);

        if (Patient == null)
        {
            return null;
        }

        if (!string.IsNullOrEmpty(editProfileDto.OldPassword))
        {
            var passwordHasher = new PasswordHasher<User>();
            var passwordResult = passwordHasher.VerifyHashedPassword(Patient, Patient.PasswordHash, editProfileDto.OldPassword);

            if (passwordResult == PasswordVerificationResult.Failed)
            {
                return null;
            }

            Patient.PasswordHash = passwordHasher.HashPassword(Patient, editProfileDto.NewPassword);
        }

        Patient.UserName = editProfileDto.UserName ?? Patient.UserName;
        Patient.Email = editProfileDto.Email ?? Patient.Email;

         _userRepository.Update(Patient); 
        await _userRepository.SaveAsync();

        return Patient;


    }
    public async Task<string> BookAppointmentAsync(int scheduleId, int patientId)
    {
        try
        {            var schedule = await _scheduleRepository.GetByIdAsync(scheduleId);

            if (schedule == null || !schedule.IsAvailable)
            {
                return "The selected schedule is not available";
            }            var appointment = new Appointment
            {
                PatientId = patientId,
                DoctorId = schedule.DoctorId,
                AppointmentDate = schedule.StartTime,
                Status = "Booked"
            };            await _appointmentRepository.AddAsync(appointment);

            schedule.IsAvailable = false;
            _scheduleRepository.Update(schedule);
            await _appointmentRepository.SaveAsync();
            await _scheduleRepository.SaveAsync();

            return "Appointment booked successfully.";
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }
    /* public async Task<Appointment> BookAppointment(int patientId, int doctorId, DateTime appointmentDate)
     {
         var doctor = await _doctorRepository.GetByIdAsync(doctorId);
         if (doctor == null)
         {
             throw new Exception("Doctor not found");
         }
         var isAvailable = await _scheduleRepository.GetAll()
             .AnyAsync(s =>
                 s.DoctorId == doctorId &&s.StartTime <= appointmentDate &&s.EndTime >= appointmentDate &&
                 s.IsAvailable
             );

         if (!isAvailable)
         {
             throw new Exception("Doctor is not available at this time");
         }
         var existingAppointment = await _appointmentRepository.GetAll()
             .AnyAsync(a => a.DoctorId == doctorId && a.AppointmentDate == appointmentDate);

         if (existingAppointment)
         {
             throw new Exception("This time slot is already booked");
         }
         var appointment = new Appointment
         {
             PatientId = patientId,
             DoctorId = doctorId,
             AppointmentDate = appointmentDate,
             Status = "Confirmed"
         };

         await _appointmentRepository.AddAsync(appointment);
         await _appointmentRepository.SaveAsync();

         return appointment;
     }*/
    public async Task<bool> RescheduleAppointment(int patientId, int appointmentId, DateTime newDateTime)
    {
        var appointment = await _appointmentRepository.GetByIdAsync(appointmentId);
        if (appointment == null)
        {
            return false; 
        }
        if (appointment.PatientId != patientId)
        {
            return false;
        }
        var isConflict = await _appointmentRepository.GetAll()
            .AnyAsync(a => a.DoctorId == appointment.DoctorId && a.AppointmentDate == newDateTime);

        if (isConflict)
        {
            return false;
        }

        appointment.AppointmentDate = newDateTime;

        appointment.Status = "Rescheduled";
        _appointmentRepository.Update(appointment);
        await _appointmentRepository.SaveAsync();

        return true; 
    }
    public async Task<bool> CancelAppointment(int patientId, int appointmentId)
    {
        var appointment = await _appointmentRepository.GetByIdAsync(appointmentId);

        if (appointment == null)
        {
            return false; 
        }

        if (appointment.PatientId != patientId)
        {
            return false; 
        }

        _appointmentRepository.Delete(appointment);
        await _appointmentRepository.SaveAsync();

        return true; 
    }

}
