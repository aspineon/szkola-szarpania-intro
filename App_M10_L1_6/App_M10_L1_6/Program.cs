using System;

namespace App_M10_L1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "To jest długi tekst";

            string krotki = tekst.Substring(0, 7);
            string czesc = tekst.Substring(8);

            Console.WriteLine(krotki);
            Console.WriteLine(czesc);
        }
    }
}
