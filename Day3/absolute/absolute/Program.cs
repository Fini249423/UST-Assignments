using System;
using System.Diagnostics.Eventing.Reader;

namespace absolute
{
    internal class program
    {
        static void Main(string[] args)
        {
            int n = 0, p = 51, absl;
            Console.WriteLine("enter a number");
            n = int.Parse(Console.ReadLine());
            absl = CalcAbsolute(n,p);
            Console.WriteLine("Absolute of the number is:{0}",absl);
            }
        static int CalcAbsolute(int n,int p)
        {
            if (n > 51)
            {
                
                return 3 * (n - p);
            }
            else
            {
                return 3*( p - n);
               
            }

        }
            

        
        

    }
}
