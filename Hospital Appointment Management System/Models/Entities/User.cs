using Hospital_Appointment_Management_System.Models;
using Hospital_Appointment_Management_System.Models.Entities;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public int RoleId { get; set; }  
    public Role Role { get; set; }
    public int? DoctorId { get; set; } 
    public Doctor Doctor { get; set; }

    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();  
}
