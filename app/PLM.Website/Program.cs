using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PLM.Website
{
    internal class Program
    {
        private static Task Main(string[] args)
        {
            return CreateHostBuilder(args).RunAsync();
        }

        private static IHost CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureLogging(logger => logger.ClearProviders())
            .ConfigureWebHostDefaults(web =>
            {
                web.UseStartup<Startup>();
            })
            .Build();
    }
}
