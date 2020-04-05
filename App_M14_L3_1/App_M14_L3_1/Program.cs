using System;
using System.IO;

namespace App_M14_L3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "To jest tekst";
            string[] lines = new string[]
            {
                "Pierwsza linia",
                "Druga linia"
            };

            File.WriteAllText("text.txt", text);
            File.WriteAllLines("lines.txt", lines);
        }
    }
}
