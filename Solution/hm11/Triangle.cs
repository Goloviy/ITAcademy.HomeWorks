using System;
using System.Collections.Generic;
using System.Text;

namespace hm11
{
    class Triangle: Square
    {
        public override double AreaFugure(double side)
        {
            return Math.Sqrt(3) / 4 * side * side;
        }
    }
}
