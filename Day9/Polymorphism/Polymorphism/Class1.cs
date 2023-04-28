using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class shape
    {
        public virtual void Drawshape()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    public class circle : shape
    {
        public override void Drawshape()
        {
            Console.WriteLine("Drawing shape");
        }
    }
}
