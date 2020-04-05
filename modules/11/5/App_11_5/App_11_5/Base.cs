using System;

namespace App_12_1
{
    class Base
    {
        public int Public;
        protected int Protected;
        private int Private;

        public Base()
        {
            Public = 1;
            Protected = 1;
            Private = 1;
        }

        public Base(int x)
        {
            Public = x;
            Protected = x;
            Private = x;
        }

        public void DisplayAll()
        {
            Console.WriteLine(Public);
            Console.WriteLine(Protected);
            Console.WriteLine(Private);
        }
    }

    class Child : Base
    {
        public Child(int x): base(x)
        {
            Protected = 10;
        }

        public Child()
        {
            Protected = 20;
        }

        public void Display()
        {
            Console.WriteLine(Public);
            Console.WriteLine(Protected);
        }
    }
}
