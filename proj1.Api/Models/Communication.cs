public class Communication
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    
    public string TypeCode { get; set; } = string.Empty;
    public CommunicationType Type { get; set; }

    public string CurrentStatus { get; set; } = string.Empty;
    public DateTime LastUpdatedUtc { get; set; }

    public ICollection<CommunicationStatusHistory> StatusHistory { get; set; } = new List<CommunicationStatusHistory>();
}
