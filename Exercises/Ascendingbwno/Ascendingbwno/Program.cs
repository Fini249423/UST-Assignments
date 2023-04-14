using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascendingbwno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the first number");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Ascending order:");
            for(int i=a; i<=b; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
