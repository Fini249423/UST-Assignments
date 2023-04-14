
//Write a program in C# Sharp to find the length of a string without using library function.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str_length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;
            Console.WriteLine("Input the string"); //input the string
            str = Console.ReadLine(); //taking the value and storing in str
            foreach (char c in str) //taking each letters using foreach from str
            {
                l += 1;     //Adding no of letters
            }
            Console.WriteLine("Length of the string is:{0}",l);
        }
    }
}
