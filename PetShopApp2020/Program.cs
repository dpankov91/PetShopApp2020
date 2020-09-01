using System;
using Microsoft.Extensions.DependencyInjection;
using PetShopApp.Coree;
using PetShopApp.Coree.ApplicationServices.Services;
using PetShopApp.Coree.ApplicationServices.Services.Implementation;
using PetShopApp.Coree.DomainServices;
using PetShopApp.Infastructure.Static.Data;
using PetShopApp.Infastructure.Static.Data.Repositories;

namespace ConsoleApp2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();
            serviceCollection.AddScoped<IPetService, PetService>();
            serviceCollection.AddScoped<IPrinter, Printer>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var petService = serviceProvider.GetRequiredService<IPetService>();
            var dataInitializer = new DataInit(petService);

            dataInitializer.InitData();

            var printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.StartUI();

            Console.ReadLine();
        }
    }
}
