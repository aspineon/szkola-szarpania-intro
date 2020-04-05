using Project.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Commands
{
    class DetailsCommand : ICommand
    {
        private ItemsManager ItemsManager;

        public DetailsCommand(ItemsManager itemsManager)
        {
            ItemsManager = itemsManager;
        }

        public string GetDescription()
        {
            return "Wyświetl szczegóły";
        }

        public string GetName()
        {
            return "DETAILS";
        }

        public void Run()
        {
            Console.WriteLine("Podaj numer: ");

            int no = int.Parse(Console.ReadLine());

            Item found = ItemsManager.GetItem(no);

            Console.Clear();
            found.DisplayDetails();

            Console.ReadKey();
        }
    }
}
