using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Anagram

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter the first string ");

            string a = Console.ReadLine();

            Console.WriteLine("Enter the second string");

            string b = Console.ReadLine();

            if (a.Length == b.Length)

            {

                char[] arr1 = a.ToLower().ToCharArray();

                char[] arr2 = b.ToLower().ToCharArray();

                Array.Sort(arr1);

                Array.Sort(arr2);

                string res1 = new string(arr1);

                string res2 = new string(arr2);

                if (res1 == res2)

                {

                    Console.WriteLine("They are anagrams");

                }

                else

                {

                    Console.WriteLine("They are not anagrams");

                }

            }

            else

            {

                Console.WriteLine("They are not anagrams");

            }

        }

    }

}