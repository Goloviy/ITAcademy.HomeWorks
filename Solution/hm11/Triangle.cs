using System;
using System.Collections.Generic;
using System.Text;

namespace hm11
{
    class Triangle: Figure
    {
        public override double AreaFugure()
        {
            return Math.Sqrt(3) / 4 * SideFigure * SideFigure;
        }
        public Triangle(string nameFigure, double sideFigure)
        {
            NameFigure = nameFigure;
            SideFigure = sideFigure;
        }
    }
}
