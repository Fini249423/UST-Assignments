using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoLINQ
{
    public class Employee
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value;} }

        private string _city;
        public string City { get { return _city; } set { _city = value; } }

        public Employee(string name,string city)
        {
            Name = name;
            City = city;
        }
        public Employee()
        {

        }


    }
    public class Program
    {
        static void Main(string[] args)
        {
                List<Employee> EmpList = new List<Employee>();


            EmpList.Add(new Employee("Arun","Hyd"));
            EmpList.Add(new Employee("Rahul","Trv"));
            EmpList.Add(new Employee("Anu","Delhi"));
            EmpList.Add(new Employee("Sree","Karnataka"));
            EmpList.Add(new Employee("Ben", "Ernklm"));
            EmpList.Add(new Employee("Amritha","Delhi"));
            EmpList.Add(new Employee("Manu","Trv"));

            var Query = from Employee emp in EmpList
                        orderby emp.City
                        group emp by emp.City;
            foreach(var e in Query)
            {
                Console.WriteLine("Employee with " + e.Key + " City:");
                foreach(var em in e)
                {
                    Console.WriteLine("" + em.Name);
                }
            }

                
        }

    }
}
