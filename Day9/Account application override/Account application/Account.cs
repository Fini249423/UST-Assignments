using System;
using System.Runtime.InteropServices;

namespace Account_application
{
    public class Account
    {
        public int id;
        private string _name;

        public string Name
        {
            get
            {
                return _name; 
            }
            set
            {
                if (value.Length > 15)
                    throw new ArgumentException("to big");
                _name=value;

            }
        }

        public int Id;
        //public string Name;
        private decimal _balance;
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;

            }
        }

        
        //private string _nominee;    //partial accesssibility example
        //public string Nominee
        //{
        //    get
        //    {
        //        return _nominee;
                
        //    }
        //}



        public void CreateAccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
            
           
        }
        

        public void DisplayInfo()
        {
            Console.WriteLine("Account Information");
            Console.WriteLine("Account id:" + Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Opening Balance" + Balance);
           // Console.WriteLine("Nominee"+ Nominee);

            
        }

        public override string ToString()
        {
            string str = "";
            str += "id:" + Id;
            str += "name:" + Name;
            str += "balance:" + Balance;
            return str;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine(Balance);
            
        }

        public void Withdrew(decimal amount)
        {
            if (Balance - amount < 500)
                Console.WriteLine("Insufficient Balance");
            else
                this.Balance -= amount;   
                Console.WriteLine(Balance);
            
            
        }
    }
}