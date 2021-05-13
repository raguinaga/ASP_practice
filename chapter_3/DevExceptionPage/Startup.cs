namespace DevExceptionPage
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;

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
