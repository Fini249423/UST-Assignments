using System;

namespace Fruits
{
    class Fruits
    {
        private int no;
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        protected string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
                else
                    Console.WriteLine("Invalid input");

            }
        }
        public Fruits(int no, string name)
        {
            No = no;
            Name = name;
        }
        public void print()
        {
            Console.WriteLine("No:" + No + "Name:" + Name);
        }



        public Fruits()
        {

        }
    }
    class orange : Fruits
    {
        private string _origin;
        public string[] org = { "Himanchal", "Maharashtra", "Telengana" };
        public string Origin
        {
            get { return _origin; }
            set
            {
                if (Array.BinarySearch(org, value) >= 0)
                    Origin = value;
                else
                    Console.WriteLine("Invalid Origin");
            }
        }
        public orange(int no, string name, string org) : base(no, name)
        {
            org = Origin;
        }

        public new void print()
        {
            base.print();
            Console.WriteLine("The origin is" + Origin);

        }
        public orange()
        {

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            orange Obj1 = new orange(2, "valencia", "Himanchal");
        }
    }
}


    

    
    
