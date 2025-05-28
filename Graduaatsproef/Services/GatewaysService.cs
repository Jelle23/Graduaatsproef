using Eywa.HealthMonitor.Contracts.Dtos;
using Eywa.HealthMonitor.Contracts.Helpers;

public class GatewaysService
{
    private List<GatewayDto> gateways = new()
    {
        new GatewayDto { ID = 1, Name = "Gateway Alpha", SerialNumber = "1001", GatewayKindName = "Edge", OwnerCompanyName = "Contoso", GatewayTypeName = "Type A", HasTunnelConnection = true, IsActive = true, Latitude=50.8465573, Longitude=4.351697 },
        new GatewayDto { ID = 2, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude=50.8465573, Longitude=4.351697 }
    };

    public async Task<List<GatewayDto>> GetGatewaysAsync(CancellationToken cancellationToken)
    {
        try
        {
            var result = await HealthMonitorHelper.HealthMonitorServiceProxy.GetGatewaysAsync(cancellationToken);
            return result.Gateways;
        }
        catch (Exception ex)
        {
            return gateways;
        }
    }

    public class Gateway
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Serienummer { get; set; }
        public string GatewayKind { get; set; }
        public string OwnerCompany { get; set; }
        public string GatewayType { get; set; }
        public string TunnelConnection { get; set; }
        public bool IsActive { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
