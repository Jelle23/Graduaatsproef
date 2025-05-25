using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class AssetsService
{
    private List<Asset> assets = new()
{
    new Asset { Id = 1, Name = "Sensor A", OwnerCompany = "Contoso", AssetType = "Temperature Sensor", IsOnline = true, IsActive = true, Latitude=50.8465573, Longitude=4.351697 },
    new Asset { Id = 2, Name = "Camera X", OwnerCompany = "Fabrikam", AssetType = "Security Camera", IsOnline = false, IsActive = true, Latitude=50.8465573, Longitude=4.351697},
    new Asset { Id = 3, Name = "Hub B", OwnerCompany = "Contoso", AssetType = "Network Hub", IsOnline = true, IsActive = false, Latitude=50.8465573, Longitude=4.351697 },
    new Asset { Id = 4, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude=50.8465573, Longitude=4.351697 }
};


    public Task<List<Asset>> GetAssetsAsync()
    {
        return Task.FromResult(assets);
    }

    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnerCompany { get; set; }
        public string AssetType { get; set; }
        public bool IsOnline { get; set; }
        public bool IsActive { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
