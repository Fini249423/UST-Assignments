using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionsort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 0, 2, 5, -1, 4, 1 };       
            int t;
            int n = a.Length;
            for(int i=0; i < n; i++) 
            {
                for(int j=i+1; j<n; j++)
                {
                    if (a[i] > a[j])
                    {
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;

                    }
                   
                }

            }
            Console.WriteLine(" \n sorted array is:");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(a[i]+ " ");
            }
        }
    }
}
