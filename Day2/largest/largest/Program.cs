using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, l;
            Console.WriteLine("enter values for a,b,c");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            l = CalcLarge(a, b, c);
            Console.WriteLine("Largest of three values is{0}", l);
        }
        static double CalcLarge(double a, double b, double c)
        {
            if(a > b && a > c)
                return  a;
            else if (b > a && b > c)
                return  b;
            else
                return  c;
        }


    }
}
