using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IBankAccount
    {
        public void Deposit(double Amount);
        public void Withdraw(double Amount);
        public void CheckBalance(); 
    }

    class SavingaAccount : IBankAccount
    {
        public void Deposit(double Amount) => Console.WriteLine($"The Deposit Amount in SavingsAccount is {Amount}");
        public void Withdraw(double Amount) => Console.WriteLine($"The Withdrawal Amount in SavingsAccount is {Amount}");
        public void CheckBalance() => Console.WriteLine("Balance has been fetched Successfully in your SavingsAccount");
    }

    class CurrentAccount : IBankAccount
    {
        public void Deposit(double Amount) => Console.WriteLine($"The Deposit Amount in CurrentAccount is {Amount}");
        public void Withdraw(double Amount) => Console.WriteLine($"The Withdrawal Amount in CurrentAccount is {Amount}");
        public void CheckBalance() => Console.WriteLine("Balance has been fetched Successfully in your CurrentAccount");

    }

    class Program
    {
        static void Main()
        {
            IBankAccount account;
            account = new SavingaAccount();

            Console.WriteLine("SavingsAccount Details");
            Console.WriteLine("----------------------------");

            account.Deposit(50000.0);
            account.Withdraw(20000.0);
            account.CheckBalance();

            account = new CurrentAccount();

            Console.WriteLine("CurrentAccount Details");
            Console.WriteLine("----------------------------");

            account.Deposit(60000.0);
            account.Withdraw(35000.0);
            account.CheckBalance();

        }
    }  
}
