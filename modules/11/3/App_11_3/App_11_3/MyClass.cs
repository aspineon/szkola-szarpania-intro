namespace App_11_3
{
    class MyClass
    {
        public int Field { get; }

        public MyClass()
        {
            // OK
            Field = 4;
        }

        public void Set()
        {
            // BŁĄD!!!
            Field = 3;
        }
    }
}
