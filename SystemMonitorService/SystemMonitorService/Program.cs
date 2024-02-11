// Program.cs
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace SystemMonitorService
{

    class Program
    {
        static async Task Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton(new List<EndpointInfo>
                {
                new EndpointInfo { Url = "https://dotnettutorials.net/lesson/types-of-constructors-in-csharp/", Threshold = 200 },
                new EndpointInfo { Url = "https://example.com/api/endpoint2", Threshold = 500 },
                new EndpointInfo { Url = "https://learn.microsoft.com/en-us/answers/questions/1338163/error-log-monitoring-using-asp-net-window-service", Threshold = 100 },
                new EndpointInfo { Url = "https://localhost:7136/swagger/index.html", Threshold = 100 },
                new EndpointInfo { Url = "https://localhost:7178/swagger/index.html", Threshold = 100 },
                    // Add more endpoints as needed
                })
                .AddSingleton<SystemMonitorService>()
                .BuildServiceProvider();

            var monitorService = serviceProvider.GetRequiredService<SystemMonitorService>();
            await monitorService.MonitorEndpointsAsync();

            Console.ReadKey();
        }
    }
}
