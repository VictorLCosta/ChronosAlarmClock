namespace Domain.Entities
{
    public class Ringtone : BaseEntity
    {
        public string Path { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
