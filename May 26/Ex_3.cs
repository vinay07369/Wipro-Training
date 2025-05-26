using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM26
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; } // "Deposit" or "Withdraw"
        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"{Date}|{Type}|{Amount}";
        }

        public static Transaction FromString(string line)
        {
            var parts = line.Split('|');
            return new Transaction
            {
                Date = DateTime.Parse(parts[0]),
                Type = parts[1],
                Amount = decimal.Parse(parts[2])
            };
        }
    }

    public class BankAccount
    {
        private List<Transaction> transactions = new List<Transaction>();

        private decimal balance = 0;

        private const string FilePath = "transactions.txt";

        public void Deposit(decimal amount)
        {
            if (amount <= 0) return;

            balance += amount;
            transactions.Add(new Transaction { Date = DateTime.Now, Type = "Deposit", Amount = amount });
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > balance) return;

            balance -= amount;
            transactions.Add(new Transaction { Date = DateTime.Now, Type = "Withdraw", Amount = amount });
        }

        public void SaveTransactions()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (var t in transactions)
                {
                    writer.WriteLine(t.ToString());
                }
            }
        }

        public void LoadTransactions()
        {
            transactions.Clear();
            balance = 0;

            if (!File.Exists(FilePath)) return;

            foreach (var line in File.ReadAllLines(FilePath))
            {
                var transaction = Transaction.FromString(line);
                transactions.Add(transaction);
                balance += (transaction.Type == "Deposit" ? transaction.Amount : -transaction.Amount);
            }
        }

        public void ShowSummary()
        {
            Console.WriteLine("\nTransaction History:");
            foreach (var t in transactions)
            {
                Console.WriteLine($"{t.Date:g} - {t.Type} - ₹{t.Amount}");
            }
            Console.WriteLine($"\nCurrent Balance: ₹{balance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.LoadTransactions();
            while (true)
            {
                Console.WriteLine("\nBank Account Menu:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Write("Enter amount to deposit: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        account.Deposit(depositAmount);
                        account.SaveTransactions();
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Enter amount to withdraw: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                    {
                        account.Withdraw(withdrawAmount);
                        account.SaveTransactions();
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                }
                else if (choice == "3")
                {
                    account.ShowSummary();
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}
