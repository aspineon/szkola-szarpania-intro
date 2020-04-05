using System;
using System.Collections.Generic;

namespace App_13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyInterface zmienna = new MyClass();

            List<int> list = new List<int>();

            ICollection<int> x = list;

            x.Add(3);

        }
    }
}
