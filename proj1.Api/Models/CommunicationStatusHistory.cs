public class CommunicationStatusHistory
{
    public int Id { get; set; }

    public Guid CommunicationId { get; set; }
    public Communication Communication { get; set; }

    public string StatusCode { get; set; } = string.Empty;
    public DateTime OccurredUtc { get; set; }
}
