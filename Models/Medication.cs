namespace MedTrack.Models
{
    public class Medication
    {
        public int MedicationId { get; set; }
        public int UserId { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Schedule { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
