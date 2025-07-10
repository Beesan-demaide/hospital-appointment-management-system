namespace Hospital_Appointment_Management_System.Dto
{
    public class SearchDoctorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public bool IsAvailable { get; set; } 
    }
}