/* The startup class handles some infrastructure of the webpage, mainly services
 and the middleware pipeline. Services are registered here and the middleware
tells the app how to respond to requests.*/
namespace HoldingPage
{
    using Microsoft.AspNetCore.Builder;
    // Start up handles service registration and middleware and endpoints
    public class Startup 
    {
        // Configure methods actually defines the middleware pipeline
        // app welcome page is the only actual middleware in the pipeline
        public void Configure(IApplicationBuilder app) => app.UseWelcomePage();
    }
}
