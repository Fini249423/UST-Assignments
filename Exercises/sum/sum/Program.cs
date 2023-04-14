//Write a Code Block to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.


using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;

            Console.WriteLine("enter the 1st number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            b = int.Parse(Console.ReadLine());
            sum = SumOfNumbers(a, b);
            Console.WriteLine("Sum of numbers is:{0}", sum);
        }
        static int SumOfNumbers(int a, int b)
        {
            if (a == b)
                return 3 * (a + b);
            else
                return a + b;
        }
        
    }
}
