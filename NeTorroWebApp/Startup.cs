using Blazored.LocalStorage;
using Blazored.Modal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NeTorroWebApp.Services;
using System;

namespace NeTorroWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddBlazoredLocalStorage();
            services.AddScoped<IPredictionService, PredictionService>();
            services.AddScoped<IFinanceService, FinanceService>();
            services.AddScoped<IUserService, AuthorizationService>();
            services.AddScoped<ISessionService, SessionService>();
            services.AddHttpClient<IUserService,AuthorizationService >(c =>
             c.BaseAddress = new Uri("https://localhost:5050/authenticate/"));
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddHttpClient<ICompanyService, CompanyService>(c =>
                c.BaseAddress = new Uri("https://localhost:5050/predictions/"));
            services.AddHttpClient<IFinanceService, FinanceService>(c =>
              c.BaseAddress = new Uri("https://localhost:5050/financialstatement/"));
            services.AddHttpClient<IPredictionService, PredictionService>(c =>
                c.BaseAddress = new Uri("https://localhost:5050/predictions/"));
            services.AddBlazoredModal();
            services.AddBlazoredLocalStorage(config =>
                config.JsonSerializerOptions.WriteIndented = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
