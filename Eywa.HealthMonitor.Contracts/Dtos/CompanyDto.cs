namespace Eywa.HealthMonitor.Contracts.Dtos
{
    public class CompanyDto
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long? ParentCompanyID { get; set; }
        public string ParentCompanyName { get; set; }
        public int NumberOfSubCompanies { get; set; }
    }
}
