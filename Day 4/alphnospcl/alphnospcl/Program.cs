
//Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphnospcl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alph, splch, dgt, l, i;
            string str;
            alph = splch = dgt = i= 0;
            Console.WriteLine("enter the statement:");
            str = Console.ReadLine();
            l = str.Length;

            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alph++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    dgt++;
                }
                else
                {
                    splch++;
                }
                i++;
            }
            Console.WriteLine("Number Of alphabets is:{0}", alph);
            Console.WriteLine("Number of digits is:{0}", dgt);
            Console.WriteLine("Number of Special Characters is:{0}", splch);
        }
    }
}

