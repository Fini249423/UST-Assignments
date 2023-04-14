using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEBUGDEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b= int.Parse(Console.ReadLine());
            fun (a, b) ;
            Console.WriteLine("Debugging Demo");
        }
        public static void fun (int a, int b)
        {
            int t = 100;
            for(int i=a; i<=b;i++)
            {
                Console.WriteLine("india");
                t = t + 34;
            }
        }
    }
}
