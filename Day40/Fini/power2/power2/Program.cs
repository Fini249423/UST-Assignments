using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PowerOfTwo
{
    class Solution //outer class
    { 
        class InnerPrivate //inner class
        {
            int remainder;
            public void powerof2(int num) //function
            {
                if (num == 1)
                    Console.Write("It is power of 2.");
                else
                {
                    while (num > 1)
                    {
                        remainder = num % 2;
                        if (remainder != 0)
                            break;
                        num /= 2;
                    }
                    if (num == 1)
                        Console.WriteLine("It is a power of 2");
                    else
                        Console.WriteLine("It is not a power of 2");
                }
            }
        }
        static void Main(string[] args) //outer class
        {
            try
            {

                Console.WriteLine("Enter a no to check");

                int num = Convert.ToInt32(Console.ReadLine());
                //outer class.inner class objectof inner class
                Solution.InnerPrivate ip = new Solution.InnerPrivate();//making inner class object
                ip.powerof2(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}