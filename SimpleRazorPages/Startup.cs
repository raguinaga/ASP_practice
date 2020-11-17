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
            // They are all also called in the literal order listed here
            app.UseExceptionHandler("/Error");
            app.UseStaticFiles();
            app.UseRouting(); // used to find razor page endpoints
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}