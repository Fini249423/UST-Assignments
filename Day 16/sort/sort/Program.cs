using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 0, 0, 1, 2, 2, 1, 0 };
            int n = A.Length;
            int count0 = 0, count1 = 0, count2 = 0;
            int i = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(A[i]);
            }
            for (i = 0; i < n; i++)
            {
                if (A[i] == 0)
                {
                    count0 += 1;
                }
                if (A[i] == 1)
                {
                    count1 += 1;
                }
                if (A[i] == 2)
                {
                   count2 += 1;
                }
            }
            for (i = 0; i < count0; i++)
            {
                A[i] = 0;
            }
            for (i = count0; i < count0 + count1; i++)
            {
                A[i] = 1;
            }
            for (i = count0 + count1; i < n; i++)
            {
                A[i] = 2;
            }
            Console.WriteLine("After sort");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(A[i]);
            }

        }

    }

}
        
    

