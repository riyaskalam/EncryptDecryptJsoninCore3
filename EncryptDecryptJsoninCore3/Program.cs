using IntegrationHub.SecureConfig;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace EncryptDecryptJsoninCore3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().EncryptSettings<ProductionSettings>(false).Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}