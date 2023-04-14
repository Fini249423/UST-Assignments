using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            paraconstructor v= new paraconstructor(100,50);
            Console.WriteLine("Constructor");
            Console.WriteLine("value of a=" + v.a);
            Console.WriteLine("value of b=" + v.b);
            return(v);
        }
    }
}
