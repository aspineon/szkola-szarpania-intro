using System;

namespace App_M11_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obiekt = new MyClass();

            // Tutaj używamy funkcji
            int wynik = obiekt.Kwadrat(3);

            obiekt.PolePowierzchni(2, 4);
        }
    }
}
