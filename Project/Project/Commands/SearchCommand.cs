using Project.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Commands
{
    class SearchCommand : ICommand
    {
        private ItemsManager ItemsManager;

        public SearchCommand(ItemsManager itemsManager)
        {
            ItemsManager = itemsManager;
        }

        public string GetDescription()
        {
            return "Szukaj";
        }

        public string GetName()
        {
            return "SEARCH";
        }

        public void Run()
        {
            string search;

            Console.WriteLine("Podaj szukają frazę: ");
            search = Console.ReadLine();

            IEnumerable<Item> items = ItemsManager.Search(search);

            Console.Clear();

            Console.WriteLine("Znalezione pozycje:");

            foreach(Item item in items)
            {
                Console.WriteLine("{0}: {1} | {2}", item.No, item.Title, item.Country);
            }

            Console.ReadKey();
        }
    }
}
