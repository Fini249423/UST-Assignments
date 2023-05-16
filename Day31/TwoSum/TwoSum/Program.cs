using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("enter the size");
            int size=int.Parse(Console.ReadLine());
            
            int[] nums = new int[size];
            for(int i = 0; i < size; i++) 
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Enter the target");
            int t=int.Parse(Console.ReadLine());
            int[] value = twoSum(nums, t);
            Console.WriteLine("{0}, {1}", value[0], value[1]);

        }
        private static int[] twoSum(int[] Arr,int t1)
        {
            int[] value = new int[2];
            for(int i=0; i<Arr.Length; i++)
            {
                for(int j=i+1; j<Arr.Length; j++)
                {
                    if ( Arr[i] + Arr[j] == t1)
                    {
                        value[0] = i;
                        value[1] = j;
                    }
                        

                    
                }
            }
            return value;
        }
            
    }
}
