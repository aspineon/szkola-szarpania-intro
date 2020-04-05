using System;
using System.Collections.Generic;
using System.Text;

namespace App_M12_L2_1
{
    class Base
    {
        public void Get()
        {
            Console.WriteLine("Base - Get()");
        }
    }

    class ChildA : Base
    {
        public void Use()
        {
            Console.WriteLine("ChildA - Use()");
        }
    }

    class ChildB : Base
    {
        public void Insert()
        {
            Console.WriteLine("ChildB - Insert()");
        }
    }
}
