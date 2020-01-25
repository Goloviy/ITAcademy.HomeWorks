using System;
using System.Collections.Generic;
using System.Text;

namespace hm11
{
    class Circle : Square
    {
        public override double AreaFugure(double side)
        {
            return  side * side * Math.PI;
        }
    }
}
