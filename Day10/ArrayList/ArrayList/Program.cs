using System;
using System.Collections;

namespace ArrayListDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arlist = new ArrayList();
            arlist.Add("True \n");
            arlist.Add("Malavika \n");
            arlist.Add("  \n");
            arlist.Add("123 \n");

            foreach (object obj in arlist)
            {
                Console.Write(obj);
            }
        }
    }
}
