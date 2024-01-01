namespace Domain.Entities
{
    public class Alarm : BaseEntity
    {
        public string? Title { get; set; }

        public TimeOnly Time { get; set; }
        public DateOnly? ScheduledDate { get; set; }
        public List<DayOfWeek>? DaysOfWeek { get; set; }

        public bool Active { get; set; }
        public bool Vibrate { get; set; }

        public Guid? RingtoneId { get; set; }
        public Ringtone? Ringtone { get; set; }
    }
}
