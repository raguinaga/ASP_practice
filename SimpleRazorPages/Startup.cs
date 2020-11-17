namespace SimpleRazorPages
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // required to use razor pages
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app)
        {
            // All methods that add middleware begin with "Using"
            app.UseExceptionHandler("/Error");
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndPoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}