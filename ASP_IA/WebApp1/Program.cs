namespace WebApp1
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args) // Returns an IHostBuilder
            .Build() // IHost Builder builds IHost
            .Run();  // IHost is run (AKA Kestrel server)
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    _ = webBuilder.UseStartup<Startup>();
                });
    }
}
