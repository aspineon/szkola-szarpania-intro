using System.Collections.Generic;
using System.IO;

namespace Project.Items
{
    class ItemsManager
    {
        private List<Item> Items;
        private string Filename;

        public ItemsManager(string filename)
        {
            Items = new List<Item>();
            Filename = filename;
        }

        public void Load()
        {
            if (!File.Exists(Filename))
            {
                return;
            }

            IEnumerable<string> lines = File.ReadAllLines(Filename);

            foreach(string line in lines)
            {
                string[] splited = line.Split('|');
                if (splited[1] == "FILM")
                {
                    LoadMovie(splited);
                }
                else if (splited[1] == "SERIAL")
                {
                    LoadSeries(splited);
                }
            }
        }

        public IEnumerable<Item> GetAll()
        {
            return Items;
        }

        public void AddMovie(string title, int year,
            string country, string description)
        {
            int lastNo = GetLastNo();

            Movie movie = new Movie(lastNo + 1, title, country, year, description);

            Items.Add(movie);
            AddToFile(movie.GetRaw());
        }

        public void AddSeries(string title, int startYear, int endYear,
            int numberOfSeasons, string country, string description)
        {
            int lastNo = GetLastNo();

            Series series = new Series(lastNo + 1, title, country, startYear, endYear, numberOfSeasons, description);

            Items.Add(series);
            AddToFile(series.GetRaw());
        }

        public IEnumerable<Item> Search(string search)
        {
            List<Item> found = new List<Item>();

            foreach(Item item in Items)
            {
                if (item.Title.Contains(search) || item.Description.Contains(search))
                {
                    found.Add(item);
                }
            }

            return found;
        }

        public Item GetItem(int no)
        {
            foreach(Item item in Items)
            {
                if (item.No == no)
                {
                    return item;
                }    
            }

            return null;
        }

        public void Remove(int no)
        {
            Item found = null;

            foreach(Item item in Items)
            {
                if (item.No == no)
                {
                    found = item;
                }
            }

            Items.Remove(found);
            UpdateFile();
        }

        private void LoadMovie(string[] splited)
        {
            int no = int.Parse(splited[0]);
            string title = splited[2];
            int year = int.Parse(splited[3]);
            string country = splited[4];
            string description = splited[5];

            Movie movie = new Movie(no, title, country, year, description);

            Items.Add(movie);
        }

        private void LoadSeries(string[] splited)
        {
            int no = int.Parse(splited[0]);
            string title = splited[2];
            int startYear = int.Parse(splited[3]);
            int endYear = int.Parse(splited[4]);
            string country = splited[5];
            int numberOfSeasons = int.Parse(splited[6]);
            string description = splited[7];

            Series series = new Series(no, title, country, startYear, endYear, numberOfSeasons, description);

            Items.Add(series);
        }

        private void UpdateFile()
        {
            List<string> lines = new List<string>();

            foreach(Item item in Items)
            {
                lines.Add(item.GetRaw());
            }

            File.WriteAllLines(Filename, lines.ToArray());
        }

        private void AddToFile(string line)
        {
            File.AppendAllLines(Filename, new string[] { line });
        }

        private int GetLastNo()
        {
            int no = 0;

            foreach(Item item in Items)
            {
                no = item.No;
            }

            return no;
        }
    }
}
