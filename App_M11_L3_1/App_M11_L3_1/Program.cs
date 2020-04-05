using System;

namespace App_M11_L3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            obj.Field = 44;
            int x = obj.Field;
        }
    }
}
