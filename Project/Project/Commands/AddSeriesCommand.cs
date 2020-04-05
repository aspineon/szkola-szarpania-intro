using Project.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Commands
{
    class AddSeriesCommand : ICommand
    {
        private ItemsManager ItemsManager;

        public AddSeriesCommand(ItemsManager itemsManager)
        {
            ItemsManager = itemsManager;
        }

        public string GetDescription()
        {
            return "Dodaj serial";
        }

        public string GetName()
        {
            return "ADDSERIES";
        }

        public void Run()
        {
            string title;
            int startYear;
            int endYear;
            int numberOfSeasons;
            string country;
            string description;

            Console.WriteLine("Nowy serial. Podaj szczegóły:");
            Console.WriteLine("Tytuł: ");
            title = Console.ReadLine();
            Console.WriteLine("Rok startu: ");
            startYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Rok zakończenia: ");
            endYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Liczba sezonów: ");
            numberOfSeasons = int.Parse(Console.ReadLine());
            Console.WriteLine("Kraj produkcji: ");
            country = Console.ReadLine();
            Console.WriteLine("Opis: ");
            description = Console.ReadLine();

            ItemsManager.AddSeries(title, startYear, endYear, numberOfSeasons, country, description);

            Console.WriteLine("Dodano serial \"{0}\"", title);
            Console.ReadKey();
        }
    }
}
