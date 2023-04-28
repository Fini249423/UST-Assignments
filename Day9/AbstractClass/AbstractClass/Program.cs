using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure fig = new Square();
            fig.Dimensions = 10;
            Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());

            Figure fig1 = new Circle();
           
            fig1.Dimensions = 2;
            Console.WriteLine(fig1.Area());
            Console.WriteLine(fig1.Perimeter());

        }
    }
}
