using System;
using System.Collections.Generic;
using System.Text;

namespace App_11_4
{
    class MyClass
    {
        private int PolePrywatne;
        public int Pole;

        public void Ustaw(int wartosc)
        {
            Pole = wartosc;
            PolePrywatne = 5;
        }
    }
}
