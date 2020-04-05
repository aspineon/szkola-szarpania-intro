namespace Project.Items
{
    abstract class Item
    {
        public int No { get; }
        public string Country { get; }
        public string Title { get; }
        public string Description { get; }

        public Item(int no, string title, string country, string description)
        {
            No = no;
            Title = title;
            Country = country;
            Description = description;
        }

        public abstract string GetRaw();
        public abstract void DisplayDetails();
    }
}
