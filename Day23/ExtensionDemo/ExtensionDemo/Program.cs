using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                //Split the string by a space
                string[] strArray = inputstring.Split(' ');
                return strArray.Count();
                
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "India is great,gfhgfh";
            int wordCount = s.GetWordCount();
            Console.WriteLine("string : " + s);
            Console.WriteLine("Count : " + wordCount);
            Console.Read();
        }
    }
}
