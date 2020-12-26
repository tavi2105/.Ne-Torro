using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PredictionsWebApp.Services;
using System;
using System.Net.Http;
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
            builder.Services.AddScoped<IFinanceService, FinanceService>();
            builder.Services.AddScoped<ICompanyService, CompanyService>();
            builder.Services.AddHttpClient<ICompanyService, CompanyService>(c =>
                c.BaseAddress = new Uri("https://localhost:5050/predictions/"));
            builder.Services.AddHttpClient<IFinanceService, FinanceService>(c =>
              c.BaseAddress = new Uri("https://localhost:5050/financialstatement/"));
            builder.Services.AddHttpClient<IPredictionService, PredictionService>(c =>
                c.BaseAddress = new Uri("https://localhost:5050/predictions/"));
            await builder.Build().RunAsync();
        }
    }
}
