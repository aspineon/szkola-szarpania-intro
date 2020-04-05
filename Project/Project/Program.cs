using Project.Commands;
using Project.Items;
using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemsManager itemsManager = new ItemsManager("db.txt");
            itemsManager.Load();

            Menu menu = new Menu(itemsManager);
            menu.Run();
        }
    }
}
