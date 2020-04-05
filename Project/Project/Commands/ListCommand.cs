using Project.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Commands
{
    class ListCommand : ICommand
    {
        private ItemsManager ItemsManager;

        public ListCommand(ItemsManager itemsManager)
        {
            ItemsManager = itemsManager;
        }

        public string GetDescription()
        {
            return "Lista";
        }

        public string GetName()
        {
            return "LIST";
        }

        public void Run()
        {
            IEnumerable<Item> list = ItemsManager.GetAll();

            foreach(Item item in list)
            {
                Console.WriteLine("{0} - {1} | {2}", item.No, item.Title, item.Country);
            }

            Console.ReadKey();
        }
    }
}
