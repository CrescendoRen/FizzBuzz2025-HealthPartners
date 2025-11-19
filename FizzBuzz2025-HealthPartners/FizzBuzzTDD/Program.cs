using FizzBuzzTDD.Handler;
using FizzBuzzTDD.Service;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzzTDD
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var services = CreateServices();

            var handler = services.GetRequiredService<IFizzBuzzHandler>();
            handler.RunFizzBuzz(0, 100, 3, 5);
        }

        private static ServiceProvider CreateServices()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IFizzBuzzHandler, FizzBuzzHandler>()
                .AddSingleton<IFBService, FBService>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}