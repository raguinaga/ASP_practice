namespace HoldingPage
{
    using Microsoft.AspNetCore.Builder;

    public class Startup
    {
        
        public void Configure(IApplicationBuilder app) => _ = app.UseWelcomePage();
    }
}
