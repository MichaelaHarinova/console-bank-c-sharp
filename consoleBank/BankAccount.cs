using System;

namespace consoleBank
{
    public class BankAccount
    {
        private Client Client;
        
        private int Balance;
        public int myBalance
        {
            get {return Balance;}
            set {Balance = value;}
        }

        private string Type;
        public string myType
        {
            get {return Type;}
            set {Type = value;}
        }
        
        public BankAccount(Client Client, string Type)
        {
            this.Balance = 0;
            this.Client = Client;
            this.Type = Type;
        }

        public int CheckBalance()
        {
            return Balance;
        }
        
        public void Withdraw(int withDrawAmount)
        {
            if (withDrawAmount > Balance)
            {
                Console.WriteLine("Nice try bro, you don't have enough money, find a job!");
                Console.WriteLine("Your actual balance is " + this.Balance);
            }
            else
            {   
                Balance -= withDrawAmount;
                Console.WriteLine("You just withdraw " + withDrawAmount);
                Console.WriteLine("Your actual balance is " + this.Balance);
            }
        } 
        public void Deposit(int inputAmount)
        { 
            this.Balance += inputAmount;
            Console.WriteLine("You deposite " + inputAmount); 
            Console.WriteLine("Your actual balance is " + CheckBalance());
        }
    }
}