using Hospital_Appointment_Management_System.Models;
using Hospital_Appointment_Management_System.Models.Entities;

public class Schedule
{
    public int Id { get; set; }
    public int DoctorId { get; set; }

    public Doctor Doctor { get; set; }  

    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public bool IsAvailable { get; set; }  
}
