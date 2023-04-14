using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimaltoBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amt,amt2,amt3,amt4,amt5,amt6,amt7,amt8,amt9;
            int total;
            Console.WriteLine("enter the amount");
            amt = int.Parse(Console.ReadLine());
            Console.WriteLine("No of 2000 notes " +amt/2000);
            amt2 = amt % 2000;
            Console.WriteLine("No of 1000 notes " + amt2 / 1000);
            amt3 = amt % 1000;
            Console.WriteLine("No of 500 notes " + amt3 / 500);
            amt4 = amt % 500;
            Console.WriteLine("No of 100 notes " + amt4 / 100);
            amt5 = amt % 100;
            Console.WriteLine("No of 50 notes " + amt5 / 50);
            amt6 = amt % 50;
            Console.WriteLine("No of 10 notes " + amt6 / 10);
            amt7 = amt % 10;
            Console.WriteLine("No of 5 notes " + amt7 / 5);
            amt8 = amt % 5;
            Console.WriteLine("No of 1 notes " + amt8 / 1);
            amt9 = amt % 1;
            total=amt+amt2+amt3+amt4+amt5+amt6+amt7+amt8+amt9;
            Console.WriteLine("Minimum Number of notes required is:"+total);
            //total=int.Parse(Console.ReadLine());

        }
    }
}
