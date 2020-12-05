using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PredictionsWebApp.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Extensions.Http;
using System.Text;
using System.Threading.Tasks;

namespace PredictionsWebApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IPredictionService, PredictionService>();
            builder.Services.AddHttpClient<IPredictionService, PredictionService>(c =>
                c.BaseAddress = new Uri("https://localhost:5050/predictions/"));
            await builder.Build().RunAsync();
        }
    }
}
