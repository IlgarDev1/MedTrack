namespace MedTrack.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string NotificationType { get; set; }
        public string Message { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime? SentAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
