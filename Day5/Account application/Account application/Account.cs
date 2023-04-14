using System;

namespace Account_application
{
    public class Account
    {
        public int Id;
        public string Name; 
        public decimal Balance ;
        

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