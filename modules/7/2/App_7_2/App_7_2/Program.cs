using System;

namespace App_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;

            bool test;

            Console.Write("Podaj liczbę całkowitą: ");
            tekst = Console.ReadLine();

            test = bool.Parse(tekst);
        }
    }
}
