using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    interface IBuilding
    {
        int AreaSquareMeters { get; set; }
        int Length { get; set; }
        int Width { get; set; }

        public static int Area(int Length, int Width, int numberOfFloors = 1)
        {
            return Length * Width * numberOfFloors;
        }
    }
}
