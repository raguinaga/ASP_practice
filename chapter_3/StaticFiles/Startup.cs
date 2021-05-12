namespace StaticFiles
{
    using Microsoft.AspNetCore.Builder;

    public class Startup
    { 
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app) => _ = app.UseStaticFiles();
    }
}
