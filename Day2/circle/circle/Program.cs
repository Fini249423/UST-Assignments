using System;

namespace circle
{
    internal class area
    {
        static void Main(string[] args)
        {
            //initialising
            double area = 0, r = 0;
            Console.WriteLine("enter radius of the circle");
            //calculating area
            r = double.Parse(Console.ReadLine());
            area = CalcArea(r);
            Console.WriteLine($"Area of circle having {r} is {area}");
        }
        static double CalcArea(double rr)
        {
            return 3.14 * rr * rr;
        }
           
        
    }
}
