using System;

namespace App_11_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obiekt1 = new MyClass();
            MyClass obiekt2 = new MyClass(5);

            Console.WriteLine(obiekt1.Pole);
            Console.WriteLine(obiekt2.Pole);
        }
    }
}
