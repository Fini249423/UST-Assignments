using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpooling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> li = new List<Member>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(" Member {0}", i + 1);
                Console.WriteLine("Id:");
                long id=long.Parse(Console.ReadLine());
                Console.WriteLine("first name:");
                string firstName=Console.ReadLine();
                Console.WriteLine("last name:");
                string lastName=Console.ReadLine();
                Console.WriteLine("email:");
                string email=Console.ReadLine();
                Console.WriteLine("contact number:");
                string contactNumber=Console.ReadLine();
                Console.WriteLine("license number:");
                string licenseNumber=Console.ReadLine();
                Console.WriteLine("license start date");
                DateTime licenseStartDate=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("license expiry date:");
                DateTime licenseExpiryDate=DateTime.Parse(Console.ReadLine());
                Member m=new Member(id,firstName,lastName,email,contactNumber,licenseNumber,licenseStartDate,licenseExpiryDate);
                li.Add(m);
                

            }

            int j = 1;
            foreach(var item in li)
            {
                Console.WriteLine("Member {0}",j);
                Console.WriteLine(item.ToString());
                j++;
            }
            if (li[0].Equals(li[1]))
            {
                Console.WriteLine("Member 1 is same as Member 2");
            }
            else
            {
                Console.WriteLine("Member 1 and Member 2 are different");
            }

           
        }
    }
}
