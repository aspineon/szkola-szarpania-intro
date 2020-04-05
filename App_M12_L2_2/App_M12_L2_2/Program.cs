using System;

namespace App_M12_L2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Base baseObj;
            ChildA childAObj = new ChildA();
            ChildB childBObj = new ChildB();

            // TERAZ SIĘ ZACZYNA!
            baseObj = childAObj;
            baseObj.Get();

            baseObj = childBObj;
            baseObj.Get();
        }
    }
}
