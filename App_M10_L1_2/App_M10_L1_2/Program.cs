using System;
using System.Collections.Generic;

namespace App_M10_L1_2
{
    class Item
    {
        public int Id;
        public string Nazwa;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>
            {
                new Item { Id = 1, Nazwa = "Item1" },
                new Item { Id = 2, Nazwa = "Item2" },
                new Item { Id = 3, Nazwa = "Item3" },
                new Item { Id = 4, Nazwa = "Item4" },
            };

            string tekst = "";

            foreach (Item item in items)
            {
                tekst += string.Format("{0}: {1}", item.Id, item.Nazwa);
            }
        }
    }
}
