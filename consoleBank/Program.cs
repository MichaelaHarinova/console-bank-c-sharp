using System;

namespace consoleBank
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            var Name = Console.ReadLine();
            
            var infoClient = new Client(1, Name);

            Console.WriteLine($"Welcome {Name}, what type of account would you like to create?");
            Console.ReadLine();
            
            var bankAccount = new BankAccount(infoClient,"type");
            Console.WriteLine(infoClient.DateJoined);
            
            
            var activeOperations = true;
            while (activeOperations)
            {
                Console.WriteLine(" Please choose number of your operation 1) Check balance, 2)Withdraw, 3)Deposit or 0) to Exit");
                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1 :
                        Console.WriteLine("Your actual balance is " + bankAccount.CheckBalance());
                        break;
                    case 2 :
                        Console.WriteLine("What amount do you want to withdraw?");
                        var withDrawAmount = int.Parse(Console.ReadLine());
                        bankAccount.Withdraw(withDrawAmount);
                        break;
                    case 3 :
                        Console.WriteLine("What amount do you wish to deposit?");
                        var inputAmount = int.Parse(Console.ReadLine());
                        bankAccount.Deposit(inputAmount);
                        break;
                    case 0 :
                        Console.WriteLine("Hastala vista, baby!");
                        activeOperations = false;
                        break;
                    default :
                        Console.WriteLine("Don't be complicated and just chose one of the options!");
                        break;
                }

                
                
            }
           
            
            
        }
    }
}
