using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2023_day_3
{
    class PositionWithStar
    {
        public Position(int number, int x, int y, PositionStar starposition)
        {
            this.Number = number;
            this.X = x;
            this.Y = y;
            this.StarPosition = starposition;
        }

        public int Number;
        public int X;
        public int Y;
        public PositionStar StarPosition;
    }
}
