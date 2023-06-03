using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger a;
            BigInteger b;
            Console.WriteLine("Enter number 1:");
            a = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2 :");
            b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = a + b;
            BigInteger d = a * b;
            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}
