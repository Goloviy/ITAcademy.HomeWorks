using System;
using System.Collections.Generic;
using System.Text;

namespace hm11
{
    class Figure
    {
        private string _nameFigure;
        public string NameFigure
        {
            get
            {
                return _nameFigure;
            }
            set
            {
                _nameFigure = value;
            }
        }

        private double _sideFigure;
        public double SideFigure
        {
            get
            {
                return _sideFigure;
            }
            set
            {
                _sideFigure = value;
            }
        }
        public virtual double AreaFugure()
        {            
            return SideFigure*SideFigure;
        }    
    }
}
