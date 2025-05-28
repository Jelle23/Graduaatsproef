public class GatewaysService
{
    private List<Gateway> gateways = new()
    {
        new Gateway { Id = 1, Name = "Gateway Alpha", Serienummer = 1001, GatewayKind = "Edge", OwnerCompany = "Contoso", GatewayType = "Type A", TunnelConnection = "VPN", IsActive = true, Latitude=50.9226832, Longitude=5.5392831 },
        new Gateway { Id = 2, Name = "Gateway Beta", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
        new Gateway { Id = 3, Name = "Gateway Gamma", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
        new Gateway { Id = 4, Name = "Gateway Delta", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
        new Gateway { Id = 5, Name = "Gateway Epsilon", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
        new Gateway { Id = 6, Name = "Gateway Zeta", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
        new Gateway { Id = 7, Name = "Gateway Eta", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
        new Gateway { Id = 8, Name = "Gateway Theta", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
        new Gateway { Id = 9, Name = "Gateway Iota", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
        new Gateway { Id = 10, Name = "Gateway Kappa", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
        new Gateway { Id = 11, Name = "Gateway Lambda", Serienummer = 1002, GatewayKind = "Cloud", OwnerCompany = "Fabrikam", GatewayType = "Type B", TunnelConnection = "SSH", IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
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
