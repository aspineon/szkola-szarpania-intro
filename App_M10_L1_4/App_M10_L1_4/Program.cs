using System;

namespace App_M10_L1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "To jest tekst";

            char znak = tekst[1];

            if (tekst.Contains("jest"))
            {
                Console.WriteLine("Tekst zawiera słowo 'jest'");
            }
        }
    }
}
