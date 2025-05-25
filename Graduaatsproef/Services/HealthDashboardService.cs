public class HealthDashboardService
{
    private readonly List<HealthDashboard> HealthDashboards = new()
    {
        new HealthDashboard { Service = "API Gateway", Status = "OK", Details = "Running normally" },
        new HealthDashboard { Service = "Database", Status = "OK", Details = "Connection stable" },
        new HealthDashboard { Service = "Measurement Service", Status = "Error", Details = "No heartbeat detected" },
        new HealthDashboard { Service = "Event Processor", Status = "Warning", Details = "Processing slowly" },
        new HealthDashboard { Service = "Log Writer", Status = "OK", Details = "All logs written" }
    };

    public Task<List<HealthDashboard>> GetHealthDashboardsAsync()
    {
        return Task.FromResult(HealthDashboards);
    }

    public class HealthDashboard
    {
        public string Service { get; set; }
        public string Status { get; set; } // OK, Warning, Error
        public string Details { get; set; }
    }
}
