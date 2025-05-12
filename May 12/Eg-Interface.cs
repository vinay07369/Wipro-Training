using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IPayment
    {
        void Processpayment(decimal amount);

    }

    //Implementing the interface in credit card payment
    class CreditCardPayment : IPayment
    {
        public void Processpayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount} ");
        }
    }

    //Implementing the interface in Paypal payment
    class PayPalPayment : IPayment
    {
        public void Processpayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Using the interface as a reference
            IPayment payment;

            //Credit card payment
            payment = new CreditCardPayment();
            payment.Processpayment(1500.50m);

            //Paypal payment
            payment = new PayPalPayment();
            payment.Processpayment(2500.70m);
        }
    }
}
