using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure fig = null;
            Console.WriteLine("enter'C' for circle or 'S' for square");
            string ch = Console.ReadLine();
            if (ch == "S")
                fig = new square();
            else if (ch == "C")
                fig = new circle();
            fig.Dimensions = 10;
            Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());
        }
    }
}
