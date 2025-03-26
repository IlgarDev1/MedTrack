namespace MedTrack.Models
{
    public class UserSettings
    {
        public int SettingId { get; set; }
        public int UserId { get; set; }
        public string Language { get; set; }
        public string TimeZone { get; set; }
        public string NotificationPreferences { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
