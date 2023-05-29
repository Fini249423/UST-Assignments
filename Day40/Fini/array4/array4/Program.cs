using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Emter the elements");

            int[] a = new int[n];

            for (int i = 0; i < n; i++)

            {

                a[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();

            foreach (int i in a)

            {

                Console.WriteLine(i);

            }
        }
    }
}
