using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size=int.Parse(Console.ReadLine());
            int num=int.Parse(Console.ReadLine());
            int[] a=new int[size];

            for(int i=0;i<size;i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }

            for(int i=0;i<size;i++)
            {
                int sum = a[i];
                if(sum==num)
                {
                    Console.WriteLine("subarray starts at{0}", i);
                    return;
                }
                else
                {
                    for(int j=i+1;j<size;j++)
                    {
                        sum += a[j];
                        if(sum==num)
                        {
                            Console.WriteLine("starts at {0} and ends at {1}", i + 1, j + 1);
                            return;
                        }
                    }
                }
            }
        }
    }
}
