using System;

namespace App_M9_L4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            while (text != "KONIEC")
            {
                Console.WriteLine("Podaj komendę:");
                text = Console.ReadLine();
            }
        }
    }
}
