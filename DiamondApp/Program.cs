using DiamondApp.Contracts;
using DiamondApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

class Program
{
    static void Main(string[] args)
    {       
        var host = CreateHostBuilder(args).Build();
       
        var app = host.Services.GetRequiredService<MainApp>();
        app.Run(args);
    }

    static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) =>
                services.AddTransient<IDiamondGenerator, DiamondGenerator>()
                        .AddTransient<IDiamondPrinter, ConsoleDiamondPrinter>()
                        .AddTransient<MainApp>());
}
