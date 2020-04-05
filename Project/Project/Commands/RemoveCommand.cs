using Project.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Commands
{
    class RemoveCommand : ICommand
    {
        private ItemsManager ItemsManager;

        public RemoveCommand(ItemsManager itemsManager)
        {
            ItemsManager = itemsManager;
        }

        public string GetDescription()
        {
            return "Usuń pozycję";
        }

        public string GetName()
        {
            return "REMOVE";
        }

        public void Run()
        {
            Console.WriteLine("Podaj numer do usunięcia: ");
            int no = int.Parse(Console.ReadLine());

            ItemsManager.Remove(no);

            Console.ReadKey();
        }
    }
}
