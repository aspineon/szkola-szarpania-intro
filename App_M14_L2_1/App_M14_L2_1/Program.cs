using System;
using System.IO;

namespace App_M14_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("plik.txt");

            string[] lines = File.ReadAllLines("plik.txt");

            Console.Write(text);

            Console.WriteLine();
            Console.WriteLine("==============");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
