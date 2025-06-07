using Eywa.HealthMonitor.Contracts.Dtos;
using Eywa.HealthMonitor.Contracts.Helpers;

public class CompanyService
{
    private List<CompanyDto> companies = new()
    {
        new CompanyDto { ID = 1, Name = "Contoso", NumberOfSubCompanies = 2 },
        new CompanyDto { ID = 2, Name = "Fabrikam", NumberOfSubCompanies = 1 },
        new CompanyDto { ID = 3, Name = "Globex", NumberOfSubCompanies = 0, ParentCompanyID = 1, ParentCompanyName = "Contoso" },
        new CompanyDto { ID = 4, Name = "VDB Service", NumberOfSubCompanies = 0, ParentCompanyID = 2, ParentCompanyName = "Fabrikam" },
        new CompanyDto { ID = 5, Name = "Dutry Power", NumberOfSubCompanies = 0, ParentCompanyID = 1, ParentCompanyName = "Contoso" },
        new CompanyDto { ID = 6, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 7, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 8, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 9, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 10, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 11, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 12, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 13, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 14, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 15, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 16, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 17, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 18, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 19, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
        new CompanyDto { ID = 20, Name = "Koninklijke Van Twist", NumberOfSubCompanies = 0 },
    };

    private Dictionary<int, List<CompanyDto>> subcompanyData = new()
    {
        [1] = new()
        {
            new CompanyDto { ID = 101, Name = "Contoso Sub A", NumberOfSubCompanies = 0, ParentCompanyID = 1, ParentCompanyName = "Contoso" },
            new CompanyDto { ID = 102, Name = "Contoso Sub B", NumberOfSubCompanies = 0, ParentCompanyID = 1, ParentCompanyName = "Contoso" }
        },
        [2] = new()
        {
            new CompanyDto { ID = 201, Name = "Fabrikam Sub A", NumberOfSubCompanies = 0, ParentCompanyID = 2, ParentCompanyName = "Fabrikam" }
        }
    };

    private Dictionary<int, List<ProjectDto>> projectData = new()
    {
        [1] = new()
        {
            new ProjectDto { ID = 1, Name = "Smart City", MinDate = new DateTimeOffset(2024, 01, 01, 0, 0, 0, TimeSpan.Zero), MaxDate = new DateTimeOffset(2024, 06, 01, 0, 0, 0, TimeSpan.Zero), IsActive = false },
            new ProjectDto { ID = 2, Name = "Green Power", MinDate = new DateTimeOffset(2024, 02, 15, 0, 0, 0, TimeSpan.Zero), MaxDate = new DateTimeOffset(2024, 12, 10, 0, 0, 0, TimeSpan.Zero), IsActive = false }
        },
        [2] = new()
        {
            new ProjectDto { ID = 3, Name = "AI Integration", MinDate = new DateTimeOffset(2025, 03, 20, 0, 0, 0, TimeSpan.Zero), MaxDate = new DateTimeOffset(2025, 09, 05, 0, 0, 0, TimeSpan.Zero), IsActive = true }
        }
    };

    // Async retrieval of all companies
    public async Task<List<CompanyDto>> GetCompaniesAsync(CancellationToken cancellationToken)
    {
        try
        {
            var result = await HealthMonitorHelper.HealthMonitorServiceProxy.GetCompaniesAsync(cancellationToken);
            companies = result.Companies;
        }
        catch { /* use default companies */ }

        return companies;
    }

    // Async retrieval of a single company by ID
    public Task<CompanyDto?> GetCompanyByIdAsync(int id)
    {
        var company = companies.FirstOrDefault(c => c.ID == id);
        return Task.FromResult(company);
    }

    // Async retrieval of subcompanies by company ID
    public async Task<List<CompanyDto>> GetSubcompaniesForCompanyAsync(int companyId, CancellationToken cancellationToken)
    {
        try
        {
            var result = await HealthMonitorHelper.HealthMonitorServiceProxy.GetSubCompaniesAsync(companyId, cancellationToken);
            return result.SubCompanies;
        }
        catch
        {
            if (subcompanyData.TryGetValue(companyId, out var list))
                return list;
            return new List<CompanyDto>();
        }
    }

    // Async retrieval of projects by company ID
    public async Task<List<ProjectDto>> GetProjectsForCompanyAsync(int companyId, CancellationToken cancellationToken)
    {
        try
        {
            var result = await HealthMonitorHelper.HealthMonitorServiceProxy.GetCompanyProjectsAsync(companyId, cancellationToken);
            return result.Projects;
        }
        catch
        {
            if (projectData.TryGetValue(companyId, out var list))
                return list;
            return new List<ProjectDto>();
        }
    }
}

// Models

public class Company
{
    public int Id { get; set; }
    public string Naam { get; set; }
    public int AantalSubcompanies { get; set; }
}

public class Subcompany
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ParentCompany { get; set; }
}

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string DateRange { get; set; }
    public bool IsActive { get; set; }
}
