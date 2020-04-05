using System;

namespace App_M9_L4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            do
            {
                Console.WriteLine("Podaj komendę:");
                text = Console.ReadLine();
            }
            while (text != "KONIEC");
        }
    }
}
