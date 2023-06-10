using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaInheritance1
{
    public class Bird:Animal
    {
        public void fly()
        {
            Console.WriteLine("I am flying");
        }
        public void sing()
        {
            Console.WriteLine("I am singing");
        }
    }
}
