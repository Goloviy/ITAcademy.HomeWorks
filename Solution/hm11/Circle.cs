using System;
using System.Collections.Generic;
using System.Text;

namespace hm11
{
    class Circle : Figure
    {
        public override double AreaFugure()
        {
            return  SideFigure * SideFigure * Math.PI;
        }
        public Circle(string nameFigure, double radiusFigure)
        {
            NameFigure = nameFigure;
            SideFigure = radiusFigure;
        }
    }
}
