using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1and100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 100;
            Console.WriteLine("Series of numbers between 1 and 100 are:");
            for(int i=a;i<b;i++)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
