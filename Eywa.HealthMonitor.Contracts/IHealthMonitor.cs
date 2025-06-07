using Eywa.HealthMonitor.Contracts.Dtos;
using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.FabricTransport;

[assembly: FabricTransportServiceRemotingProvider(RemotingListenerVersion = RemotingListenerVersion.V2, RemotingClientVersion = RemotingClientVersion.V2)]
namespace Eywa.HealthMonitor.Contracts
{
    public interface IHealthMonitor : IService
    {
        Task<GetCompaniesResponse> GetCompaniesAsync(CancellationToken cancellationToken);
        Task<GetCompanyResponse> GetSubCompaniesAsync(long companyId, CancellationToken cancellationToken);
        Task<GetCompanyProjectsResponse> GetCompanyProjectsAsync(long companyId, CancellationToken cancellationToken);
        Task<GetGatewaysResponse> GetGatewaysAsync(CancellationToken cancellationToken);
    }
}
