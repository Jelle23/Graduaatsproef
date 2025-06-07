using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class GatewayTypeService
{
    private readonly List<GatewayType> gatewayTypes = new()
    {
        new GatewayType { Id = 1, Name = "LoRa Gateway", AantalGateways = 2 },
        new GatewayType { Id = 2, Name = "WiFi Gateway", AantalGateways = 1 },
        new GatewayType { Id = 3, Name = "5G Gateway", AantalGateways = 1 }
    };

    private readonly Dictionary<int, List<Gateway>> gatewaysByType = new()
    {
        [1] = new()
        {
            new Gateway { Id = 101, Name = "LoRa Hub A", OwnerCompany = "Contoso", IsOnline = true, IsActive = true, GatewayTypeId = 1 },
            new Gateway { Id = 102, Name = "LoRa Hub B", OwnerCompany = "Fabrikam", IsOnline = false, IsActive = true, GatewayTypeId = 1 }
        },
        [2] = new()
        {
            new Gateway { Id = 201, Name = "WiFi Node X", OwnerCompany = "Globex", IsOnline = true, IsActive = false, GatewayTypeId = 2 }
        },
        [3] = new()
        {
            new Gateway { Id = 301, Name = "5G Bridge Y", OwnerCompany = "Contoso", IsOnline = false, IsActive = false, GatewayTypeId = 3 }
        }
    };

    public Task<List<GatewayType>> GetGatewayTypesAsync()
    {
        return Task.FromResult(gatewayTypes);
    }

    public Task<GatewayType?> GetGatewayTypeByIdAsync(int id)
    {
        var gt = gatewayTypes.FirstOrDefault(t => t.Id == id);
        return Task.FromResult(gt);
    }

    public Task<List<Gateway>> GetGatewaysByTypeAsync(int gatewayTypeId)
    {
        if (gatewaysByType.TryGetValue(gatewayTypeId, out var list))
            return Task.FromResult(list);
        return Task.FromResult(new List<Gateway>());
    }
}

// Models

public class GatewayType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AantalGateways { get; set; }
}

public class Gateway
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string OwnerCompany { get; set; }
    public bool IsOnline { get; set; }
    public bool IsActive { get; set; }
    public int GatewayTypeId { get; set; }
}
