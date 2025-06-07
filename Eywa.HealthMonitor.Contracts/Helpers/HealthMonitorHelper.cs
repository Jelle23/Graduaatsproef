using Microsoft.ServiceFabric.Services.Remoting.Client;

namespace Eywa.HealthMonitor.Contracts.Helpers
{
    public static class HealthMonitorHelper
    {
        #region Constants
        public const string HealthMonitorServiceUriString = "fabric:/Eywa.Fabric/HealthMonitorService";
        #endregion

        #region Properties
        public static IHealthMonitor HealthMonitorServiceProxy
        {
            get { return ServiceProxy.Create<IHealthMonitor>(new Uri(HealthMonitorServiceUriString)); }
        }
        #endregion
    }
}
