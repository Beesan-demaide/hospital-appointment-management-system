using System.ComponentModel.DataAnnotations;

namespace Hospital_Appointment_Management_System.Dto
{
    public class EditProfileDto
    {
        public int? Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? OldPassword { get; set; } 
        public string? NewPassword { get; set; }
    }
}
