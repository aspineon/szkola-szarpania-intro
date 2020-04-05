using System;
using System.Collections.Generic;

namespace App_M9_L2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>
            {
                1, 2, 3, 4
            };

            lista.Add(12);
            lista.Add(5);
            lista.Add(1);

            int wartosc = lista[2];

            if (lista.Contains(23))
            {
                Console.WriteLine("Lista zawiera liczbę 23");
            }

            int dlugosc_listy = lista.Count;
        }
    }
}
