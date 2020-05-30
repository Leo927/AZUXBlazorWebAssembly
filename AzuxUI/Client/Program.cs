using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using AzuxUI.Shared.DataAccess;

namespace AzuxUI.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Register Syncfusion license 
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjY0OTEyQDMxMzgyZTMxMmUzMFhZd3JqZGdRYzFBOUFjWVFJRkFVVU5lUHhLQ1ZGR2pOK1lJSEYwZ2JYM1k9");
                       
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor(true);

            ApiHelper.InitializeClient();

            await builder.Build().RunAsync();
        }
    }
}
