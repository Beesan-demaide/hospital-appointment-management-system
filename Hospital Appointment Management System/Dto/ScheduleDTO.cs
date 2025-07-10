using Hospital_Appointment_Management_System.Models.Entities;


namespace Hospital_Appointment_Management_System.Dto
{
    public class ScheduleDTO
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAvailable { get; set; }
    }
}
