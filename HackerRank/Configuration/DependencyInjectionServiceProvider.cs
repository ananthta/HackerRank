using System;
using HackerRank.StringManipulations;
using HackerRank.StringManipulations.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace HackerRank.Configuration
{
    public static class DependencyInjectionServiceProvider
    {
        public static IServiceProvider Get()
        {
            return _serviceProvider ?? (_serviceProvider = GetServiceCollection().BuildServiceProvider());
        }

        private static IServiceCollection GetServiceCollection()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging();
            serviceCollection.TryAddSingleton<ISherlockAndValidString, SherlockAndValidString>();
            serviceCollection.TryAddSingleton<IPallindromicSubstring, PallindromicSubstring>();
            serviceCollection.TryAddSingleton<ICommonChild, CommonChild>();
            serviceCollection.TryAddSingleton<IAbbrevation, Abbrevation>();
            return serviceCollection;
        }

        private static IServiceProvider _serviceProvider;
    }
}
