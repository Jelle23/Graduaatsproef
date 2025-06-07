using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class AssetsService
{
    private List<Asset> assets = new()
{
        new Asset { Id = 1, Name = "Sensor A", OwnerCompany = "Contoso", AssetType = "Temperature Sensor", IsOnline = true, IsActive = true, Latitude = 50.929447, Longitude = 5.536231 },
        new Asset { Id = 2, Name = "Camera X", OwnerCompany = "Fabrikam", AssetType = "Security Camera", IsOnline = false, IsActive = true, Latitude = 50.913176, Longitude = 5.548917 },
        new Asset { Id = 3, Name = "Hub B", OwnerCompany = "Contoso", AssetType = "Network Hub", IsOnline = true, IsActive = false, Latitude = 50.919034, Longitude = 5.531853 },
        new Asset { Id = 4, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.915392, Longitude = 5.544472 },
        new Asset { Id = 5, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.916251, Longitude = 5.538405 },
        new Asset { Id = 6, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.917965, Longitude = 5.548221 },
        new Asset { Id = 7, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.911843, Longitude = 5.541329 },
        new Asset { Id = 8, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.924764, Longitude = 5.545611 },
        new Asset { Id = 9, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.926572, Longitude = 5.542339 },
        new Asset { Id = 10, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.930421, Longitude = 5.540477 },
        new Asset { Id = 11, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.923308, Longitude = 5.528336 },
        new Asset { Id = 12, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.931759, Longitude = 5.548763 },
        new Asset { Id = 13, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.913982, Longitude = 5.537289 },
        new Asset { Id = 14, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.928012, Longitude = 5.535122 },
        new Asset { Id = 15, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.916928, Longitude = 5.549091 },
        new Asset { Id = 16, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.929651, Longitude = 5.543804 },
        new Asset { Id = 17, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.915034, Longitude = 5.534761 },
        new Asset { Id = 18, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.927286, Longitude = 5.530338 },
        new Asset { Id = 19, Name = "Light Z", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.918287, Longitude = 5.533218 },
        new Asset { Id = 20, Name = "Zight L", OwnerCompany = "Globex", AssetType = "Smart Light", IsOnline = false, IsActive = false, Latitude = 50.921732, Longitude = 5.548356 },

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
