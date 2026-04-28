using Microsoft.AspNetCore.Mvc;
using StatusApi.Models;

namespace StatusApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class StatusController : ControllerBase
    {
        private static readonly IReadOnlyList<SystemStatus> Systems = new List<SystemStatus>
        {
            new SystemStatus { Name = "Admin Panel", Status = "Operational", Uptime = 100.0, StartDate = "90 days ago", CurrentDate = "Today" },
            new SystemStatus { Name = "One-time payment", Status = "Operational", Uptime = 100.0, StartDate = "90 days ago", CurrentDate = "Today" },
            new SystemStatus { Name = "Customer registration", Status = "Operational", Uptime = 100.0, StartDate = "90 days ago", CurrentDate = "Today" },
            new SystemStatus { Name = "Customer portal", Status = "Operational", Uptime = 100.0, StartDate = "90 days ago", CurrentDate = "Today" }
        };

        private static readonly IReadOnlyList<IncidentDay> Incidents = new List<IncidentDay>
        {
            new IncidentDay
            {
                Date = "Apr 22, 2026",
                Incidents = new[] { new IncidentEntry { Text = "No incidents reported today." } }
            },
            new IncidentDay
            {
                Date = "Apr 21, 2026",
                Incidents = new[] { new IncidentEntry { Text = "No incidents reported." } }
            },
            new IncidentDay
            {
                Date = "Apr 20, 2026",
                Incidents = new[] { new IncidentEntry { Text = "No incidents reported." } }
            },
            new IncidentDay
            {
                Date = "Apr 19, 2026",
                Incidents = new[] { new IncidentEntry { Text = "No incidents reported." } }
            },
            new IncidentDay
            {
                Date = "Apr 18, 2026",
                Incidents = new[] { new IncidentEntry { Text = "No incidents reported." } }
            },
            new IncidentDay
            {
                Date = "Apr 17, 2026",
                Incidents = new[]
                {
                    new IncidentEntry
                    {
                        Title = "Problems with inbound customer service calls with Swedish support line",
                        Status = "Resolved",
                        StatusMessage = "This incident has been resolved.",
                        Time = "Apr 17, 14:07 EEST",
                        Description = "Our customer service provider is facing problems with inbound customer service calls with Swedish support line."
                    }
                }
            }
        };

        [HttpGet("status")]
        public ActionResult<IEnumerable<SystemStatus>> GetStatus()
        {
            return Ok(Systems);
        }

        [HttpGet("incidents")]
        public ActionResult<IEnumerable<IncidentDay>> GetIncidents()
        {
            return Ok(Incidents);
        }
    }
}