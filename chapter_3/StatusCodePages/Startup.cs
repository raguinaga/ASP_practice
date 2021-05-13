namespace StatusCodePages
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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) => _ = services.AddRazorPages();

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /* Status code pages with re-execute re-runs the pipeline whenever a 4XX or 5XX
             * error code is encountered. The string will be replaced in the pipeline with the
             * error code and the routing or static file middleware will handle the error page
             * being served
             */
            _ = app.UseStatusCodePagesWithReExecute("/{0}");    

            _ = app.UseStaticFiles();

            _ = app.UseRouting();

            _ = app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapRazorPages();
            });
        }
    }
}
