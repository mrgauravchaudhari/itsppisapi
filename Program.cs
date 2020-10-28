using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace itsppisapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>().UseUrls("http://localhost:8085");
        // .UseStartup<Startup>().UseUrls("http://win-server:8085");
        // .UseStartup<Startup>().UseUrls("http://192.168.201.27:8085");
    }
}
