using System;

namespace Project.Items
{
    class Series : Item
    {
        public int StartYear { get; }
        public int EndYear { get; }
        public int NumberOfSeasons { get; }

        public Series(int no, string title, string country,
            int startYear, int endYear, int numberOfSeasons, string description)
            : base(no, title, country, description)
        {
            StartYear = startYear;
            EndYear = endYear;
            NumberOfSeasons = numberOfSeasons;
        }

        public override string GetRaw()
        {
            return string.Format("{0}|SERIAL|{1}|{2}|{3}|{4}|{5}|{6}", No, Title, StartYear, EndYear, Country, NumberOfSeasons, Description);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("{0}: {1}", No, Title);
            Console.WriteLine("Kraj: {0}", Country);
            Console.WriteLine("Rok produkcji: {0} - {1}", StartYear, EndYear);
            Console.WriteLine("Liczba sezonów: {0}", NumberOfSeasons);
            Console.WriteLine("\nOpis:\n{0}", Description);
        }
    }
}
