using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class AssetTypeService
{
    private readonly List<AssetType> assetTypes = new()
    {
        new AssetType { Id = 1, Naam = "Temperature Sensor", AantalAssets = 2 },
        new AssetType { Id = 2, Naam = "Security Camera", AantalAssets = 1 },
        new AssetType { Id = 3, Naam = "Smart Light", AantalAssets = 1 }
    };

    private readonly Dictionary<int, List<Asset>> assetsByType = new()
    {
        [1] = new()
        {
            new Asset { Id = 101, Name = "Sensor A1", OwnerCompany = "Contoso", IsOnline = true, IsActive = true },
            new Asset { Id = 102, Name = "Sensor A2", OwnerCompany = "Fabrikam", IsOnline = false, IsActive = true }
        },
        [2] = new()
        {
            new Asset { Id = 201, Name = "Cam X1", OwnerCompany = "Globex", IsOnline = true, IsActive = false }
        },
        [3] = new()
        {
            new Asset { Id = 301, Name = "Light L1", OwnerCompany = "Contoso", IsOnline = false, IsActive = true }
        }
    };

    public Task<List<AssetType>> GetAssetTypesAsync()
    {
        return Task.FromResult(assetTypes);
    }

    public Task<AssetType?> GetAssetTypeByIdAsync(int id)
    {
        var type = assetTypes.FirstOrDefault(t => t.Id == id);
        return Task.FromResult(type);
    }

    public Task<List<Asset>> GetAssetsByTypeAsync(int typeId)
    {
        if (assetsByType.TryGetValue(typeId, out var list))
            return Task.FromResult(list);
        return Task.FromResult(new List<Asset>());
    }
}

// Models

public class AssetType
{
    public int Id { get; set; }
    public string Naam { get; set; }
    public int AantalAssets { get; set; }
}

public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string OwnerCompany { get; set; }
    public bool IsOnline { get; set; }
    public bool IsActive { get; set; }
}
