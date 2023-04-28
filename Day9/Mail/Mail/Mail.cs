using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace MailFolder
{
    public class Mail
    {
        private long _id;
        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;

            }
        }
        private string _to;
        public string To
        {
            get
            {
                return _to;
            }
            set
            {
                _to = value;

            }
        }
        private string _from;
        public string From
        {
            get
            {
                return _from;
            }
            set
            {
                _from = value;

            }
        }
        private string _subject;
        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;

            }
        }
        private string _content;
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;

            }
        }
        private DateTime _receivedDate;
        public DateTime ReceivedDate
        {
            get
            {
                return _receivedDate;
            }
            set
            {
                _receivedDate = value;

            }
        }
        private double _size;
        public double Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;

            }
        }

        public Mail()
        {

        }

        public Mail(long id,string to,string from,string subject,string content,DateTime receivedDate,double size)
        {
             _id = id;
             _to = to;
             _from = from;
             _subject = subject;
             _content = content;
             _receivedDate = receivedDate;
             _size = size;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}\nTo: {1}\n From: {2}\n Subject: {3}\n Content: {4}\n ReceivedDate: {5}\n Size: {6}", _id, _to, _from, _subject, _content, _receivedDate, _size);

        }


        public override bool Equals(object obj)
        {
            Mail temp = obj as Mail;
            if(temp.To==To  && temp.From==From && temp.Subject==Subject && temp.Content==Content )
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //public static bool Equals(Mail mail1, Mail mail2)
        //{
        //    if (mail1 == null && mail2 == null)
        //    {
        //        return false;
        //    }
        //    return mail1.Id == mail2.Id
        //        && mail1.To == mail2.To
        //        && mail1.From == mail2.From
        //        && mail1.Subject == mail2.Subject
        //        && mail1.Content == mail2.Content
        //        && mail1.ReceivedDate == mail2.ReceivedDate
        //        && mail1.Size == mail2.Size;

        //}




    }
}