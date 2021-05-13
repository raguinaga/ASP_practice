namespace SimpleRazorPage
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;


    public class Startup
    {

        public void ConfigureServices(IServiceCollection services) => _ = services.AddRazorPages();

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            // app.UseWelcomePage(); <- This would short circuit the pipeline
            _ = app.UseExceptionHandler("/Error");
            _ = app.UseStaticFiles();
            _ = app.UseRouting();

            // This would never execute with the welcome page active
            _ = app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapRazorPages();
            });
        }
    }
}
