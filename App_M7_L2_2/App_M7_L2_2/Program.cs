using System;

namespace App_M7_L2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;

            int liczba1;
            decimal liczba2;

            Console.Write("Podaj liczbę całkowitą: ");
            tekst = Console.ReadLine();

            liczba1 = int.Parse(tekst);

            Console.Write("Podaj liczbę 'z przecinkiem': ");
            tekst = Console.ReadLine();

            liczba2 = decimal.Parse(tekst);

            Console.WriteLine("Podane liczby to: {0} i {1}", liczba1, liczba2);
        }
    }
}
