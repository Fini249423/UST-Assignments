using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            //if generics we can add below code
            //SortedList<string,string>s = new SortedList<string,string>();
            s.Add("Maharashtra", "Mumbai");
            s.Add("Karnataka", "Bangalore");
            s.Add("Andhra Pradesh", "Hyderabad");
            s.Add("Tamilnadu", "Chennai");
            s.Add("Bihar", "Patna");
            s.Add("Rajasthan", "Jaipur");
            s.Add("Orissa", "Bhubaneshwar");
            Console.WriteLine("Elements in the sorted list:");
            foreach(var item in s.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in s.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
