using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolder
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Mail>li=new List<Mail>();
            for (int k = 1; k <= 2; k++)
            {
                Console.WriteLine($"Enter the mail {k} details", k + 1);
                string input = Console.ReadLine();
                string[] i = input.Split(',');
                Mail mail1 = new Mail(long.Parse(i[0]), i[1], i[2], i[3], i[4], DateTime.Parse(i[5]/*("dd-MM-yyyy",null)*/), double.Parse(i[6]/*("0.0")*/));

                string[] inputs = input.Split(',');
                Console.WriteLine(mail1);

            }
            
            if (li[0].Equals(li[1]))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("different");
            }






        }
    }
}












