using System;

namespace App_M13_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyInterface zmienna = new MyClass();

            zmienna = new AnotherClass();
        }
    }
}
