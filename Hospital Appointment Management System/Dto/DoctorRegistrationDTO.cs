using Hospital_Appointment_Management_System.Models.Entities;

namespace Hospital_Appointment_Management_System.Dto
{
    public class DoctorRegistrationDTO
    {
        public Doctor Doctor { get; set; } = new Doctor();
        public string Password { get; set; }
    }
}
