using Project.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Commands
{
    class AddMovieCommand : ICommand
    {
        private ItemsManager ItemsManager;

        public AddMovieCommand(ItemsManager itemsManager)
        {
            ItemsManager = itemsManager;
        }

        public string GetDescription()
        {
            return "Dodaj film";
        }

        public string GetName()
        {
            return "ADDMOVIE";
        }

        public void Run()
        {
            string title;
            int year;
            string country;
            string description;

            Console.WriteLine("Nowy serial. Podaj szczegóły:");
            Console.WriteLine("Tytuł: ");
            title = Console.ReadLine();
            Console.WriteLine("Rok produkcji: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Kraj produkcji: ");
            country = Console.ReadLine();
            Console.WriteLine("Opis: ");
            description = Console.ReadLine();

            ItemsManager.AddMovie(title, year, country, description);

            Console.WriteLine("Dodano film \"{0}\"", title);
            Console.ReadKey();
        }
    }
}
