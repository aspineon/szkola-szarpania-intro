using System;

namespace App_M8_L3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string komenda = Console.ReadLine();

            switch (komenda)
            {
                case "ADD":
                    // Dodaj
                    break;
                case "REMOVE":
                    // Usuń
                    break;
                case "EXIT":
                    // Zamknij
                    break;
                default:
                    // Nieznana komenda
                    break;
            }
        }
    }
}
