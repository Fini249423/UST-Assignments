using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimaltobinary2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans;
            string rslt;
            Console.WriteLine("Enter a number");
            ans= Console.ReadLine();

            int num=Convert.ToInt32(ans);
            rslt = "";

            while(num>0)
            {
                int rem = num % 2;
                rslt = Convert.ToString(rem) + rslt;
                num/= 2;
            }
            Console.WriteLine("Binary value is{0}", rslt);

        }
    }
}
