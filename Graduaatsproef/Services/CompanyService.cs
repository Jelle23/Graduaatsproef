using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CompanyService
{
    private List<Company> companies = new()
    {
        new Company { Id = 1, Naam = "Contoso", AantalSubcompanies = 2 },
        new Company { Id = 2, Naam = "Fabrikam", AantalSubcompanies = 1 },
        new Company { Id = 3, Naam = "Globex", AantalSubcompanies = 0 },
        new Company { Id = 4, Naam = "VDB Service", AantalSubcompanies = 0 },
        new Company { Id = 5, Naam = "Dutry Power", AantalSubcompanies = 0 },
        new Company { Id = 6, Naam = "Koninklijke Van Twist", AantalSubcompanies = 0 }
    };

    private Dictionary<int, List<Subcompany>> subcompanyData = new()
    {
        [1] = new()
        {
            new Subcompany { Id = 101, Name = "Contoso Sub A", ParentCompany = "Contoso" },
            new Subcompany { Id = 102, Name = "Contoso Sub B", ParentCompany = "Contoso" }
        },
        [2] = new()
        {
            new Subcompany { Id = 201, Name = "Fabrikam Sub A", ParentCompany = "Fabrikam" }
        }
    };

    private Dictionary<int, List<Project>> projectData = new()
    {
        [1] = new()
        {
            new Project { Id = 1, Name = "Smart City", DateRange = "Jan - Jun 2024", IsActive = true },
            new Project { Id = 2, Name = "Green Power", DateRange = "Feb - Dec 2024", IsActive = false }
        },
        [2] = new()
        {
            new Project { Id = 3, Name = "AI Integration", DateRange = "Mar - Sep 2024", IsActive = true }
        }
    };

    // Async retrieval of all companies
    public Task<List<Company>> GetCompaniesAsync()
    {
        return Task.FromResult(companies);
    }

    // Async retrieval of a single company by ID
    public Task<Company?> GetCompanyByIdAsync(int id)
    {
        var company = companies.FirstOrDefault(c => c.Id == id);
        return Task.FromResult(company);
    }

    // Async retrieval of subcompanies by company ID
    public Task<List<Subcompany>> GetSubcompaniesForCompanyAsync(int companyId)
    {
        if (subcompanyData.TryGetValue(companyId, out var list))
            return Task.FromResult(list);
        return Task.FromResult(new List<Subcompany>());
    }

    // Async retrieval of projects by company ID
    public Task<List<Project>> GetProjectsForCompanyAsync(int companyId)
    {
        if (projectData.TryGetValue(companyId, out var list))
            return Task.FromResult(list);
        return Task.FromResult(new List<Project>());
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
