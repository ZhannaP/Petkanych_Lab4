using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Cinema: PublicBuilding, IBuilding
    {
        public DateTime BuildDate { get; private set; }
        public int Length { get; set; } = 50;
        public int Width { get; set; } = 40;
        public int AreaSquareMeters { get; set; }
        public int Places { get; set; } = 200;
        public int PopcornPrice { get; set; } = 100;

        public List<KeyValuePair<string, int>> films = new List<KeyValuePair<string, int>>();

        public Cinema(DateTime date)
        {
            BuildDate = date;
            AreaSquareMeters = IBuilding.Area(Length, Width);
            FillFilms();
        }


        public override int TicketPrice(string film)
        {
            int filmPrice=10;
            foreach (var x in films)
            {
                if (x.Key == film) filmPrice = x.Value;
            }
            int price= AreaSquareMeters / Places;
            return price + filmPrice;
        }

        private void FillFilms()
        {
            
            films.Add(new KeyValuePair<string, int>("Home alone", 40));
            films.Add(new KeyValuePair<string, int>("Lion king", 20));
            films.Add(new KeyValuePair<string, int>("Avengers", 50));
            films.Add(new KeyValuePair<string, int>("Avengers 2", 70));
            films.Add(new KeyValuePair<string, int>("Cinderela", 70));
        }

    }
}
