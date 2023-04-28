using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Programl
    {
        static void Main(string[] args)
        {
            shape s1 = new shape();
            s1.Drawshape();

            circle c1 = new circle();
            c1.Drawshape();

            shape s2 = new circle();
            s2.Drawshape();

            //array of references of base class refer
        }
    }

    
}
