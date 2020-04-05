using System;

namespace App_M8_L3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna = 5;

            if (zmienna > 10)
            {
                Console.WriteLine("{0} jest większe od 10", zmienna);
            }
            else if (zmienna > 6)
            {
                Console.WriteLine("{0} jest większe od 6", zmienna);
            }
            else if (zmienna > 3)
            {
                Console.WriteLine("{0} jest większe od 3", zmienna);
            }
        }
    }
}
