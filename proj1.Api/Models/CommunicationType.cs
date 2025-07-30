public class CommunicationType
{
    public string TypeCode { get; set; } = string.Empty; // Primary Key
    public string DisplayName { get; set; } = string.Empty;

    public ICollection<CommunicationTypeStatus> AllowedStatuses { get; set; } = new List<CommunicationTypeStatus>();
}
