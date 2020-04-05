using System;

namespace App_M8_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool warunek1 = 1 > 4 && 4 < 5;
            bool warunek2 = warunek1 || !warunek1;
            bool warunek3 = "Tekst" != "tekst";

            Console.WriteLine("1 > 4 && 4 < 5 = {0}", warunek1);
            Console.WriteLine("warunek1 || !warunek1 = {0}", warunek2);
            Console.WriteLine("\"Tekst\" != \"tekst\" = {0}", warunek3);
        }
    }
}
