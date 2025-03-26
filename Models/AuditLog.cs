namespace MedTrack.Models
{
    public class AuditLog
    {
        public int LogId { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public string ActionDetails { get; set; }
        public DateTime ActionTime { get; set; } = DateTime.UtcNow;
    }
}
