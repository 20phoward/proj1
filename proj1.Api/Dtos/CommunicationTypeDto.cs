namespace proj1.api.Dtos
{
    public class CommunicationTypeDto
    {
        public string TypeCode { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;

        public List<StatusOptionDto> AllowedStatuses { get; set; } = new();
    }
}
