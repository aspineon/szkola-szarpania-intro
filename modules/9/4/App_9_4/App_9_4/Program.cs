using System;

namespace App_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 9; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
