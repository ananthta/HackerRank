using System;
using HackerRank.Configuration;
using HackerRank.StringManipulations.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NLog;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var target = DependencyInjectionServiceProvider.Get().GetService<IAbbrevation>();
            Logger.Info(target.abbreviation("daBcd", "ABC"));

        }

        private static ILogger Logger = LogManager.GetCurrentClassLogger();
   }
}
