namespace DevExceptionPage
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.HttpsPolicy;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) => _ = services.AddRazorPages();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            _ = app.UseDeveloperExceptionPage();
            _ = app.UseStaticFiles();
            _ = app.UseRouting();

            _ = app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapRazorPages();
            });
        }
    }
}
