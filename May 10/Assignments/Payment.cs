using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Payment
    {
        public double Amount;

        public string Currency;

        public void ProcessPayment()
        {
            Console.WriteLine($"The Amount is:{Amount}");
            Console.WriteLine($"The currency is:{Currency}");
        }
    }

    class CreditCardPayment : Payment
    {

        public long CardNumber;
        public void ProcessPayment(double Amount)
        {
            Console.WriteLine($"The Amount in CreditCard Payment:{Amount}");
        }

        public void ProcessPayment(double Amount, string Currency)
        {
            Console.WriteLine($"The Amount in CreditCard Payment:{Amount}");
            Console.WriteLine($"The Currency in CreditCard Payment:{Currency}");
        }

    }

    class PayPalPayment : Payment
    {
        public string EmailAddress;

        public void ProcessPayment(double Amount)
        {
            Console.WriteLine($"The Amount in Paypal Payment:{Amount}");
        }

        public void ProcessPayment(double Amount, string Currency)
        {
            Console.WriteLine($"The Amount in Paypal Payment:{Amount}");
            Console.WriteLine($"The Currency in Payment:{Currency}");

        }
    }

    class Program
    {
        static void Main()
        { 
            CreditCardPayment cd = new CreditCardPayment();

            PayPalPayment pp = new PayPalPayment();

            Console.WriteLine("Credit Card payment Details");
            Console.WriteLine("------------------------------");
            cd.ProcessPayment(50000.0);
            cd.ProcessPayment(50000.0,"Rupees");

            Console.WriteLine("Paypal payment Details");
            Console.WriteLine("------------------------------");
            pp.ProcessPayment(70000.0);
            pp.ProcessPayment(70000.0, "Rupees");
        }
    }
}