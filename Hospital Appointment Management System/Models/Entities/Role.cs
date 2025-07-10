using Hospital_Appointment_Management_System.Models;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<User> Users { get; set; } = new List<User>();  
}
