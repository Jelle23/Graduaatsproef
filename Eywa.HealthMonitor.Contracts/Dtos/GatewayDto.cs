namespace Eywa.HealthMonitor.Contracts.Dtos
{
    public class GatewayDto
    {
        public long ID { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string OwnerCompanyName { get; set; }
        public string GatewayTypeName { get; set; }
        public string GatewayKindName { get; set; }
        public bool HasTunnelConnection { get; set; }

        // TODO: add support for the following items
        public bool IsActive { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
