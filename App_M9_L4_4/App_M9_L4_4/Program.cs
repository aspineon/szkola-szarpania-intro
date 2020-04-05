using System;

namespace App_M9_L4_4
{
    class Test
    {
        public Test(int liczba, string tekst)
        {
            Liczba = liczba;
            Tekst = tekst;
        }

        public int Liczba { get; set; }
        public string Tekst { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Test> lista = new List<Test>
            {
                new Test(1, "Test1"),
                new Test(2, "Test2"),
                new Test(3, "Test3"),
                new Test(4, "Test4"),
            };

            foreach (Test element in lista)
            {
                Console.WriteLine("Wybrany element {0}, z tekstem {1}", element.Liczba, element.Tekst);
            }
        }
    }
}
