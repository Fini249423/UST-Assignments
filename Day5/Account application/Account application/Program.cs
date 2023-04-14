using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("*********************************");
                Console.WriteLine("******Account Application******");
                Console.WriteLine("*********************************");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Display Account Of Application");
                Console.WriteLine("3. Deposit Amount");
                Console.WriteLine("4. Withdraw Amount");
                Console.WriteLine("0. Quit");
                Console.WriteLine(" Enter Your Choice:");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Account ID");
                        int Id= int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        string Name = (Console.ReadLine());
                        Console.WriteLine("Enter Opening Balance");
                        decimal Balance= decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.CreateAccount(Id,Name, Balance);
                        break;
                     case 2:
                        if (a != null)
                            a.DisplayInfo();
                        else
                            Console.WriteLine("Open Account");

                        break;
                     case 3:
                        if (a != null)
                        //    Console.WriteLine("enter deposit amount");
                        //decimal Am = decimal.Parse(Console.ReadLine());
                         a.Deposit(5000);
                        else
                            Console.WriteLine("Open Account First");
                        break;
                    case 4:
                        if (a != null)
                            a.Withdrew(100);
                        else
                            Console.WriteLine("Open Account");
                        break;






                }

            } while (ch != 0);
        }
    }

   
}
