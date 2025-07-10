
using System.Text.Json.Serialization;

namespace Hospital_Appointment_Management_System.Models.Entities
{

    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        [JsonIgnore]
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();  
    }
}
