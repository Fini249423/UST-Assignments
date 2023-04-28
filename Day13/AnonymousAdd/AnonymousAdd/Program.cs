using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousAdd
{
    
    internal class Program
    {
        public delegate int Add(int i, int j);
        static void Main(string[] args)
        {
            int result;
            Add a = delegate (int x, int y)
            {
                
                return x + y;
                
            };
            result = a(10, 20);
            Console.WriteLine(result);
           

        }
    }
}
