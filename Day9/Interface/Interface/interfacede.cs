using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IFigure
    {
        int Dimensions { get; set; }
        double Area();
        double Perimeter();

        
    }

    class circle : IFigure
    {
        private int _dimensions;
        public int Dimensions
        {
            get { return _dimensions; }
            set { _dimensions = value; }
        }
        public double Area()
        {
            return  Math.PI *_dimensions;
        }

        public double Perimeter()
        {
            return Math.PI * 2 * _dimensions;
        }
    }
    class square : IFigure
    {
        private int _dimensions;
        public int Dimensions
        {
            get { return _dimensions; }
            set { _dimensions = value; }
        }
        public double Area()
        {
            return _dimensions * _dimensions;
        }

        public double Perimeter()
        {
            return  4 * _dimensions;
        }
    }
    



    }


