using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract class LivingBuilding : Building, IBuilding
    {
        public DateTime BuildDate { get; private set; }
        public int TicketPrice { get; set; }
        public int Length { get; set; } = 50;
        public int Width { get; set; }=40;
        private int floors = 20;
        private int rooms { get; set; } = 50;
        public int AreaSquareMeters { get; set; }
        private int pricePerSquareMeter = 200;

        public LivingBuilding(DateTime date)
        {
            BuildDate = date;
            AreaSquareMeters = IBuilding.Area(Length, Width, floors);
        }

        public override int Rent(string s ="")
        {
            int roomAreaSquareMeters = AreaSquareMeters / rooms;
            return roomAreaSquareMeters * pricePerSquareMeter;
        }   

    }
}
