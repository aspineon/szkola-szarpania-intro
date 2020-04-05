using System;
using System.IO;

namespace App_M14_L3_2
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

            File.AppendAllText("text.txt", text);
            File.AppendAllLines("lines.txt", lines);
        }
    }
}
