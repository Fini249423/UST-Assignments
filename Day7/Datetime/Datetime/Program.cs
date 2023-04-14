using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //output is current date and time
            Console.WriteLine(DateTime.Now);

            //output is year,month,day order
            DateTime dt1 = new DateTime(2023, 4, 11);
            Console.WriteLine(dt1);

            //output is year,month,day,hour,min,seconds order
            DateTime dt2 = new DateTime(2023, 4, 11, 7, 12, 26);
            Console.WriteLine(dt2);

            // output is ticks date and time expressed in the number of 100-nanosecond intervals
            DateTime dt3 = new DateTime(636370000000000000);
            Console.WriteLine(dt3);
        }
    }
}
