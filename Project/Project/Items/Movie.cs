using System;

namespace Project.Items
{
    class Movie : Item
    {
        public int Year { get; }


        public Movie(int no, string title, string country, int year, string description)
            : base(no, title, country, description)
        {
            Year = year;
        }

        public override string GetRaw()
        {
            return string.Format("{0}|FILM|{1}|{2}|{3}|{4}", No, Title, Year, Country, Description);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("{0}: {1}", No, Title);
            Console.WriteLine("Kraj: {0}", Country);
            Console.WriteLine("Rok produkcji: {0}", Year);
            Console.WriteLine("\nOpis:\n{0}", Description);
        }
    }
}
