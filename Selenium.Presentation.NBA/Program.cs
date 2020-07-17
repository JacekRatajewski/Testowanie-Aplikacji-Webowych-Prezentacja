using Microsoft.Extensions.DependencyInjection;
using Selenium.Presentation.NBA.Interfaces;
using Selenium.Presentation.NBA.Processors;
using System;

namespace Selenium.Presentation.NBA
{
    class Program
    {
        private static ServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();
            Console.WriteLine("NBA Roster!");
            IServiceScope scope = _serviceProvider.CreateScope();
            scope.ServiceProvider.GetRequiredService<Roster>().Execute();
            DisposeServices();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IPlayerStatisticsProcessor, PlayerStatisticsProcesor>();
            services.AddSingleton<IRosterRollerProcessor, RosterRollerProcessor>();
            _serviceProvider = services.BuildServiceProvider(true);
        }

        private static void DisposeServices()
        {
            {
                if (_serviceProvider == null)
                {
                    return;
                }
                if (_serviceProvider is IDisposable)
                {
                    (_serviceProvider).Dispose();
                }
            }
        }

    }
}
