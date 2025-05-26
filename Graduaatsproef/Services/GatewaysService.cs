public class GatewaysService
{
    private List<Gateway> gateways = new()
    {
        new Gateway { Id = 1, Name = "Gateway Alpha", Serienummer = 1001, GatewayKind = "Edge", OwnerCompany = "Contoso", GatewayType = "Type A", TunnelConnection = "VPN", IsActive = true, Latitude=50.8465573, Longitude=4.351697 },
        new Gateway { Id = 2, Name = "Gateway Beta", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 }
    };

    public Task<List<Gateway>> GetGatewaysAsync()
    {
        return Task.FromResult(gateways);
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
