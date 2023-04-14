//Create a base class Telephone and derive a class ElectronicPhone from it.In Telephone create a protected string member
//phonetype ana a public method Ring() which outputs a text message such as 'Ringing the <phonetype>'. In ElectronicPhone
//the constructor should set the phonetype to 'digital'. In the Run() method, call Ring() on the ElectronicPhone to
//test the inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    class Telephone
    {
        protected string phonetype;

        public void Ring(string pht)
        {
            pht = phonetype;
            Console.WriteLine("Ringing the " + pht);
        }
    }
    class ElectronicPhone : Telephone
    {
        public ElectronicPhone() 
        {
            phonetype = "Digital";
        }

        public void Run()
        {
            base.Ring(phonetype);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            ElectronicPhone e1= new ElectronicPhone();
            e1.Run();
        }
    }
}




