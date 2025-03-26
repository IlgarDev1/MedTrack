namespace MedTrack.Models
{
    public class Symptom
    {
        public int SymptomId { get; set; }
        public int UserId { get; set; }
        public string SymptomDescription { get; set; }
        public DateTime RecordedAt { get; set; } = DateTime.UtcNow;
        public int SeverityLevel { get; set; }
        public string Notes { get; set; }
    }

}
