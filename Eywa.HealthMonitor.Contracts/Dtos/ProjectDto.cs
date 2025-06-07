namespace Eywa.HealthMonitor.Contracts.Dtos
{
    public class ProjectDto
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTimeOffset? MinDate { get; set; }
        public DateTimeOffset? MaxDate { get; set; }
        public long CompanyID { get; set; }
        public bool IsActive { get; set; }
    }
}
