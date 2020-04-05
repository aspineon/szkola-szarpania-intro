using System;
using System.Collections.Generic;
using System.Text;

namespace App_M11_L2_2
{
    class MyClass
    {
        private int Pole;

        public int ZwrocPole()
        {
            return Pole;
        }

        public void UstawPole(int wartosc)
        {
            Pole = wartosc;
        }

        public int Oblicz(int parametr)
        {
            int wynik = Pole * parametr;

            return wynik;
        }
    }
}
