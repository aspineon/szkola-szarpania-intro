using System;

namespace App_M12_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            ChildA childAObj = new ChildA();
            ChildB childBObj = new ChildB();

            // TO JUŻ ZNAMY
            baseObj.Get();
            childAObj.Get();
            childBObj.Get();

            // TERAZ SIĘ ZACZYNA!
            baseObj = childBObj;
            baseObj.Get();

            baseObj = childBObj;
            baseObj.Get();
        }
    }
}
