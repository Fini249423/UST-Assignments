using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaInheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adder adder = new Adder();
            int result = adder.Add(42,13);
            Console.WriteLine("My superclass is:Arithmetic");
            Console.WriteLine("Sum is " + result);
        }
    }
}
