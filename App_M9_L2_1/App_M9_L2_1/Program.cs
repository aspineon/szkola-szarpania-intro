using System;

namespace App_M9_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[] { 1, 2, 3 };

            tablica[0] = 10;

            Console.WriteLine(tablica[0]);
            Console.WriteLine(tablica[1]);
            Console.WriteLine(tablica[2]);
        }
    }
}
