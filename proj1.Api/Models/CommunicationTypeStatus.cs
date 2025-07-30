public class CommunicationTypeStatus
{
    public string TypeCode { get; set; }
    public CommunicationType CommunicationType { get; set; }

    public string StatusCode { get; set; }
    public string Description { get; set; } = string.Empty;
}
