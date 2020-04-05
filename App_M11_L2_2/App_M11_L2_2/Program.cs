using System;

namespace App_M11_L2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obiekt = new MyClass();
            MyClass obiekt2 = new MyClass();

            obiekt.UstawPole(4);
            obiekt2.UstawPole(10);

            int wynik = obiekt.Oblicz(4);
            int wynik2 = obiekt2.Oblicz(4);

            Console.WriteLine(wynik);
            Console.WriteLine(wynik2);
        }
    }
}
