//Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,age;
            Console.WriteLine("enter the age");
            a=int.Parse(Console.ReadLine());
            age = VoteEligible(a);
          
  
        }
        static int VoteEligible(int a)
        {
            if (a > 18)
            {
                Console.WriteLine("Eligible for vote");
                return a;
            }
            else
                Console.WriteLine("Not eligible for vote");
            return a;
        }
    }
}
