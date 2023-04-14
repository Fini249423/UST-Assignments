using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,j;
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine());
            for(j =1;j<=10;j++)
            {
                Console.WriteLine("{0}*{1}={2}\n",n,j,n*j);

            }
        }
    }
}
