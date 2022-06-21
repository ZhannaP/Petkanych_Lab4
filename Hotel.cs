using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Hotel : Building, IBuilding
    {
        public DateTime BuildDate { get; private set; }
        public int Length { get; set; } = 80;
        public int Width { get; set; } = 50;
        public int AreaSquareMeters { get; set; }
        public int Rooms { get; set; } = 200;
        public int ParkingPrice { get; set; } = 200;
        public int Floors { get; set; }

        public List<KeyValuePair<string, int>> rooms = new List<KeyValuePair<string, int>>();

       

        public Hotel(DateTime date)
        {
            BuildDate = date;
            AreaSquareMeters = IBuilding.Area(Length, Width, Floors);
        }

        public override int Rent(string room)
        {
            int pricePerRoom = 0;

            foreach (var x in rooms)
            {
                if (x.Key == room) pricePerRoom = x.Value;
            }
            
            int roomAreaSquareMeters = AreaSquareMeters / Rooms;
            return roomAreaSquareMeters * pricePerRoom;
        }

        public void FillRooms()
        {
            rooms.Add(new KeyValuePair<string, int>("Standard", 200));
            rooms.Add(new KeyValuePair<string, int>("Superior", 300));
            rooms.Add(new KeyValuePair<string, int>("Studio", 400));
            rooms.Add(new KeyValuePair<string, int>("Lux", 500));
            rooms.Add(new KeyValuePair<string, int>("President", 1000));
        }

    }
}
