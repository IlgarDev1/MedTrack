namespace MedTrack.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Location { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
