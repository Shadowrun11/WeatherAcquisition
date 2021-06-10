using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Polly;
using Polly.Extensions.Http;


namespace WeatherAcquisition.ConsoleUI
{
    class Program
    {

        private static IHost __Hosting;

        public static IHost Hosting => __Hosting ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        public static IServiceProvider Services => Hosting.Services;
        public static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(ConfigureServices);

        private static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            throw new NotImplementedException();
        }

        static async Task Main(string[] args)
        {
            using var host = Hosting;
            await host.StartAsync();




            Console.WriteLine();
            Console.WriteLine("Completed");
            Console.ReadLine();

            await host.StopAsync();           
        }
    }
}
