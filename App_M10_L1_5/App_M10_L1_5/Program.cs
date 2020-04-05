using System;

namespace App_M10_L1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Kowalski,Nowak,Smith,Zając";

            string[] nazwiska = tekst.Split(',');

            foreach (string nazwisko in nazwiska)
            {
                Console.WriteLine(nazwisko);
            }
        }
    }
}
