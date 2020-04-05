using System;

namespace App_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass obiekt = new MyClass();
            obiekt.Liczba = 5;

            int zmienna = obiekt.Liczba;


            MyClass obiekt1 = new MyClass();
            obiekt1.Liczba = 5;

            // obiekt1.Liczba = 5
            // obiekt2.Liczba = 5
            MyClass obiekt2 = obiekt1;

            obiekt1.Liczba = 3;

            // obiekt1.Liczba = 3
            // obiekt2.Liczba = 3
        }
    }
}
