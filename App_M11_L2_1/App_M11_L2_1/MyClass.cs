using System;
using System.Collections.Generic;
using System.Text;

namespace App_M11_L2_1
{
    class MyClass
    {
        public int Kwadrat(int liczba)
        {
            int wynik = liczba * liczba;

            return wynik;
        }

        public int PolePowierzchni(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return 0;
            }

            return a * b;
        }
    }
}
