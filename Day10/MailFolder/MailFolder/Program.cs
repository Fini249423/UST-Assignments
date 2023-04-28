using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolder
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mail>ls=new List<Mail>();
            Console.WriteLine("Enter the name of the folder");
            string name = Console.ReadLine();
            Mailfolder folder = new Mailfolder(name,ls);
            Mail a = new Mail();
            
            while (true)
            {
                Console.WriteLine("\n1. Add Mail");
                Console.WriteLine("\n2. Delete Mail");
                Console.WriteLine("\n3. Display Mail");
                Console.WriteLine("\n4. Exit");
                Console.WriteLine("\n Enter choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the details of mail in CSV format:");
                        string[] s = Console.ReadLine().Split(',');
                        long _id = long.Parse(s[0]);
                        string _from = s[1];
                        string _to = s[2];
                        string _subject = s[3];
                        string _content = s[4];
                        DateTime _receivedDate = DateTime.Parse(s[5]);
                        double _size = double.Parse(s[6]);
                        Mail mail = new Mail(_id, _from, _to, _subject, _content, _receivedDate, _size);
                        
                        
                        folder.AddMailToFolder(mail);
                        //Console.WriteLine("Mail successfully added");
                        break;

                    case 2:
                        Console.WriteLine("Enter the ID of the mail to be deleted");
                        long id =long.Parse(Console.ReadLine());
                        folder.RemoveMailFromFolder(id);
                       
                        break;

                    case 3:
                        folder.DisplayMails();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\n Invalid Choice");
                        break;



                }



            }
            
        }
    }
}
