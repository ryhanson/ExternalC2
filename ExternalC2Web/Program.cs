using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ExternalC2Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            // TODO: Add more elegant command line parsing
            return WebHost.CreateDefaultBuilder(args)
                .UseUrls(args[1])
                .UseStartup<Startup>()
                .Build();
        }
    }
}