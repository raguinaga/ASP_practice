namespace StaticFiles
{
    using Microsoft.AspNetCore.Builder;

    public class Startup
    { 
        /* ASP automatically adds a error handling end point 
         * without any intervention */
        public void Configure(IApplicationBuilder app) => _ = app.UseStaticFiles();
    }
}
