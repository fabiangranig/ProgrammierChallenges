using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2023_day_3
{
    class Position
    {
        public Position(int number, int x, int y, bool hassymbol)
        {
            this.Number = number;
            this.X = x;
            this.Y = y;
            this.HasSymbol = hassymbol;
        }

        public int Number;
        public int X;
        public int Y;
        public bool HasSymbol;
    }
}
