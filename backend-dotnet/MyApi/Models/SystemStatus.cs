namespace StatusApi.Models
{
    public class SystemStatus
    {
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public double Uptime { get; set; }
        public string StartDate { get; set; } = string.Empty;
        public string CurrentDate { get; set; } = string.Empty;
    }
}