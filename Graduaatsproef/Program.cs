using Microsoft.ServiceFabric.Services.Runtime;
using System.Diagnostics;

namespace Graduaatsproef
{
    internal static class Program
    {
#if DEBUGNOFABRIC
        private static readonly bool _runInServiceFabric = false;
#else
        private static readonly bool _runInServiceFabric = true;
#endif

        /// <summary>
        /// This is the entry point of the service host process.
        /// </summary>
        private static void Main()
        {
            if (!_runInServiceFabric)
            {
                // In debug mode, run the service as a console application.
                // This is useful for local testing without Service Fabric.
                var builder = WebApplication.CreateBuilder();
                var host = Panopticon.BuildApp(builder);
                host.Run();

                return;
            }

            try
            {

                // The ServiceManifest.XML file defines one or more service type names.
                // Registering a service maps a service type name to a .NET type.
                // When Service Fabric creates an instance of this service type,
                // an instance of the class is created in this host process.

                ServiceRuntime.RegisterServiceAsync("PanopticonType",
                    context => new Panopticon(context)).GetAwaiter().GetResult();

                ServiceEventSource.Current.ServiceTypeRegistered(Process.GetCurrentProcess().Id, typeof(Panopticon).Name);

                // Prevents this host process from terminating so services keeps running. 
                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception e)
            {
                ServiceEventSource.Current.ServiceHostInitializationFailed(e.ToString());
                throw;
            }
        }
    }
}
