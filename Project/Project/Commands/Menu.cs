using Project.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Commands
{
    class Menu
    {
        private IEnumerable<ICommand> Commands;

        public Menu(ItemsManager itemsManager)
        {
            Commands = new ICommand[]
            {
                new ListCommand(itemsManager),
                new SearchCommand(itemsManager),
                new DetailsCommand(itemsManager),
                new AddMovieCommand(itemsManager),
                new AddSeriesCommand(itemsManager),
                new RemoveCommand(itemsManager)
            };
        }

        public void Run()
        {
            string input;

            do
            {
                foreach (ICommand command in Commands)
                {
                    Console.WriteLine("{0}: {1}", command.GetName(), command.GetDescription());
                }
                Console.WriteLine("KONIEC: Zakończ");
                Console.WriteLine("\nWpisz nazwę komendy: ");
                input = Console.ReadLine();
                RunCommand(input);
            }
            while (input != "KONIEC");
        }

        public void RunCommand(string name)
        {
            if (name == "KONIEC")
            {
                return;
            }

            ICommand selected = null;

            foreach(ICommand command in Commands)
            {
                if (command.GetName() == name)
                {
                    selected = command;
                    break;
                }
            }

            if (selected == null)
            {
                Console.WriteLine("== NIEZNANA KOMENDA ==");
            }
            else
            {
                Console.Clear();
                selected.Run();
                Console.Clear();
            }
        }
    }
}
