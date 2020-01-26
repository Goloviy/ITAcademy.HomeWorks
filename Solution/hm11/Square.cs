using System;
using System.Collections.Generic;
using System.Text;

namespace hm11
{
    class Square : Figure
    {
        public override double AreaFugure()
        {
            return base.AreaFugure();
        }

        public Square (string nameFigure, double sideFigure)
        {
            NameFigure = nameFigure;
            SideFigure = sideFigure;
        }
    }
}
