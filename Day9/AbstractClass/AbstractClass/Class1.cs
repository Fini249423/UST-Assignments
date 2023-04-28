using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Figure
    {
        public int Dimensions;
        public abstract double Area();
        public abstract double Perimeter();

    }

    class Square:Figure
    {
        public override double Area()
        {
            return  Dimensions * Dimensions;

        }

        public override double Perimeter()
        {
            return 4 * Dimensions;
        }
    }

    class Circle : Figure
    {
        public override double Area()
        {
            return 3.14*Dimensions;

        }

        public override double Perimeter()
        {
            return 2*3.14*Dimensions;
        }
    }
}
