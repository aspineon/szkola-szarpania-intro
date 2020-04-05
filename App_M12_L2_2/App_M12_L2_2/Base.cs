using System;
using System.Collections.Generic;
using System.Text;

namespace App_M12_L2_2
{
    abstract class Base
    {
        public virtual void Get()
        {
            Console.WriteLine("Base - Get()");
        }
    }

    class ChildA : Base
    {
        public override void Get()
        {
            Console.WriteLine("ChildA - Get()");
        }
    }

    class ChildB : Base
    {
    }
}
