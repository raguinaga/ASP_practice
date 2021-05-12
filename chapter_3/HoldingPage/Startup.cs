namespace HoldingPage
{
    using Microsoft.AspNetCore.Builder;

    public class Startup
    {
        /* IApplicationBuilder only has extension methods that are generics
         * and allow for adding middleware without coupling it to the class */
        public void Configure(IApplicationBuilder app) => _ = app.UseWelcomePage();
    }
}
