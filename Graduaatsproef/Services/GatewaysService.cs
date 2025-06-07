using Eywa.HealthMonitor.Contracts.Dtos;
using Eywa.HealthMonitor.Contracts.Helpers;

public class GatewaysService
{
    private List<GatewayDto> gateways = new()
    {
        new GatewayDto { ID = 1, Name = "Gateway Alpha", SerialNumber = "1001", GatewayKindName = "Edge", OwnerCompanyName = "Contoso", GatewayTypeName = "Type A", HasTunnelConnection = true, IsActive = true, Latitude = 50.929104, Longitude = 5.545879 },
        new GatewayDto { ID = 2, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.913784, Longitude = 5.534220 },
        new GatewayDto { ID = 3, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.917392, Longitude = 5.547395 },
        new GatewayDto { ID = 4, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.921378, Longitude = 5.531653 },
        new GatewayDto { ID = 5, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.927128, Longitude = 5.544911 },
        new GatewayDto { ID = 6, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.922821, Longitude = 5.542178 },
        new GatewayDto { ID = 7, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.916104, Longitude = 5.540120 },
        new GatewayDto { ID = 8, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.920645, Longitude = 5.535555 },
        new GatewayDto { ID = 9, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.914552, Longitude = 5.538749 },
        new GatewayDto { ID = 10, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.919967, Longitude = 5.548800 },
        new GatewayDto { ID = 11, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.923599, Longitude = 5.532024 },
        new GatewayDto { ID = 12, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.925271, Longitude = 5.539970 },
        new GatewayDto { ID = 13, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.918104, Longitude = 5.536801 },
        new GatewayDto { ID = 14, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.926732, Longitude = 5.533145 },
        new GatewayDto { ID = 15, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.921471, Longitude = 5.537687 },
        new GatewayDto { ID = 16, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.917592, Longitude = 5.543323 },
        new GatewayDto { ID = 17, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.919492, Longitude = 5.530876 },
        new GatewayDto { ID = 18, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.915102, Longitude = 5.541910 },
        new GatewayDto { ID = 19, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.928134, Longitude = 5.540506 },
        new GatewayDto { ID = 20, Name = "Gateway Beta", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.922398, Longitude = 5.545239 },
        new GatewayDto { ID = 10764, Name = "telraam_9000007382", SerialNumber = "telraam_3537857283151595", GatewayKindName = "VirtualGatewayHost", OwnerCompanyName = "Calculus", GatewayTypeName = "Telraam", HasTunnelConnection = false, IsActive = false, Latitude = 50.916736, Longitude = 5.537385 },
        new GatewayDto { ID = 21, Name = "Alpha Gateway", SerialNumber = "1002", GatewayKindName = "Cloud", OwnerCompanyName = "Fabrikam", GatewayTypeName = "Type B", HasTunnelConnection = false, IsActive = false, Latitude = 50.924529, Longitude = 5.534882 },


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
