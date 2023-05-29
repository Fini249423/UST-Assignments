using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the sentence");
                string input = Console.ReadLine();
                string output = Regex.Replace(input,@"(?i)\b(\w+)(\s+\1)+\b", "$1");
                Console.WriteLine(output);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
