using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

//_name   string

//_mailList	List<Mail>

namespace MailFolder
{
    public class Mailfolder
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;

            }
        }
        private List<Mail> _mailList;
        public List<Mail> MailList
        {
            get
            {
                return _mailList;
            }
            set
            {
                _mailList = value;

            }
        }
        public Mailfolder()
        {

        }

        public Mailfolder(string name, List<Mail> mailList)
        {
            _name = name;
            _mailList = mailList;
            
        }
        public Mailfolder(string _name)
        {
            _name = Name;
            _mailList=new List<Mail>();   //empty list
        }
        public void AddMailToFolder(Mail mail)
        {
            _mailList.Add(mail);
            Console.WriteLine("Mail added successfully");
        }
        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach(var item in _mailList)
            {
                if (item.Id==id)
                {
                    MailList.Remove(item);
                    Console.WriteLine("Mail deleted successfully");
                    count = 1;
                    break;

                }
                else
                {
                    Console.WriteLine("Mail not found in the folder");
                }
            }
            if(count==1)
            {
                return true;
            
            }
            else
            {
                return false;
            }
        }
        public void DisplayMails()
        {
            Console.WriteLine();
            if (MailList.Count==0)
            {
                Console.WriteLine("No mails to show");
            }
            else
            {
                Console.WriteLine("Mails in {0}\n", MailList);
                Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15}","_id","_from","_to","_subject","_content", "_receivedDate", "_size");
                foreach(Mail mail in _mailList)
                {
                    Console.WriteLine(mail);
                }
            }
        }
    }
}
