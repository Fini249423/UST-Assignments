using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatchdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] a = new int[5];
            try
            {
                i=int.Parse(Console.ReadLine());
                int k = 12 / i;
                Console.WriteLine(k);
                a[10] = 9;
            }
            catch(DivideByZeroException e)
            
            {
                Console.WriteLine(/*Divided by zero error*/e.Message);

            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine( "Index out of bound");
            }
            finally
            {
                Console.WriteLine("DONE");
            }
            Console.WriteLine("remaining program");
        }
    }
}
