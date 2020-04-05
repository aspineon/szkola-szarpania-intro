using System;

namespace App_M8_L3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna = 5;

            if (zmienna > 4)
            {
                Console.WriteLine("{0} jest większe od 4", zmienna);
            }
            else if (zmienna > 0)
            {
                Console.WriteLine("{0} jest większe od 0", zmienna);
            }
            else
            {
                Console.WriteLine("{0} jest ujemne");
            }
        }
    }
}
