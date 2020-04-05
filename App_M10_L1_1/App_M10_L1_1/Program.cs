using System;

namespace App_M10_L1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "TEST";

            string tekst = "Przykładowy " + test;

            int wynik = 4;

            tekst = "Wynik: " + wynik;

            Console.WriteLine("Wynik: {0}", wynik);
        }
    }
}
