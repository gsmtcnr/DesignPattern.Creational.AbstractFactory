using DesignPattern.Creational.AbstractFactory.Providers;
using System;

namespace DesignPattern.Creational.AbstractFactory.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProviderManager providerManager = new ProviderManager();

            providerManager.Select("select query..");

            Console.ReadLine();
        }
    }
}
