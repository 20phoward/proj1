namespace proj1.Api.Dtos
{
    public class StatusHistoryDto
    {
        public string StatusCode { get; set; } = string.Empty;
        public DateTime OccurredUtc { get; set; }
    }
}
