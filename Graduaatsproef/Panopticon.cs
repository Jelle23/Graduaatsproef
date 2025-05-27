using Graduaatsproef.Components;
using Microsoft.ServiceFabric.Services.Communication.AspNetCore;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Radzen;
using System.Fabric;

namespace Graduaatsproef
{
    internal sealed class Panopticon : StatelessService
    {
        public Panopticon(StatelessServiceContext context)
            : base(context)
        { }

        /// <summary>
        /// Optional override to create listeners (like tcp, http) for this service instance.
        /// </summary>
        /// <returns>The collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return new ServiceInstanceListener[]
            {
                new ServiceInstanceListener(serviceContext =>
                    new KestrelCommunicationListener(serviceContext, "ServiceEndpoint", (url, listener) =>
                    {
                        ServiceEventSource.Current.ServiceMessage(serviceContext, $"Starting Kestrel on {url}");

                        var builder = WebApplication.CreateBuilder();

                        builder.Services.AddSingleton<StatelessServiceContext>(serviceContext);
                        builder.WebHost
                                    .UseKestrel()
                                    .UseContentRoot(Directory.GetCurrentDirectory())
                                    .UseServiceFabricIntegration(listener, ServiceFabricIntegrationOptions.None)
                                    .UseUrls(url);
                        
                        // Add services to the container.
                        builder.Services.AddRazorComponents()
                              .AddInteractiveServerComponents().AddHubOptions(options => options.MaximumReceiveMessageSize = 10 * 1024 * 1024);

                        builder.Services.AddControllers();
                        builder.Services.AddRadzenComponents();
                        builder.Services.AddScoped<DialogService>();

                        builder.Services.AddScoped<AssetsService>();
                        builder.Services.AddScoped<AssetTypeService>();
                        builder.Services.AddScoped<CompanyService>();
                        builder.Services.AddScoped<GatewaysService>();
                        builder.Services.AddScoped<GatewayTypeService>();
                        builder.Services.AddScoped<HealthDashboardService>();
                        builder.Services.AddScoped<StatisticsService>();


                        builder.Services.AddRadzenCookieThemeService(options =>
                        {
                            options.Name = "GraduaatsproefTheme";
                            options.Duration = TimeSpan.FromDays(365);
                        });
                        builder.Services.AddHttpClient();

                        var app = builder.Build();

                        var forwardingOptions = new ForwardedHeadersOptions()
                        {
                            ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto
                        };
                        forwardingOptions.KnownNetworks.Clear();
                        forwardingOptions.KnownProxies.Clear();

                        app.UseForwardedHeaders(forwardingOptions);
    

                        // Configure the HTTP request pipeline.
                        if (!app.Environment.IsDevelopment())
                        {
                            app.UseExceptionHandler("/Error", createScopeForErrors: true);
                            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                            app.UseHsts();
                        }

                        app.UseHttpsRedirection();
                        app.MapControllers();
                        app.UseStaticFiles();
                        app.UseAntiforgery();

                        app.MapRazorComponents<App>()
                           .AddInteractiveServerRenderMode();

                        return app;

                    }))
            };
        }
    }
}
