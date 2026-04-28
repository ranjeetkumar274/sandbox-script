namespace StatusApi.Models
{
    public class IncidentEntry
    {
        public string Text { get; set; } = string.Empty;
        public string? Title { get; set; }
        public string? Status { get; set; }
        public string? StatusMessage { get; set; }
        public string? Time { get; set; }
        public string? Description { get; set; }
    }

    public class IncidentDay
    {
        public string Date { get; set; } = string.Empty;
        public IEnumerable<IncidentEntry> Incidents { get; set; } = Array.Empty<IncidentEntry>();
    }
}