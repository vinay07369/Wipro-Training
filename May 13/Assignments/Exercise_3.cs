using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class PaymentGateway
    {
        public abstract void ProcessPayment(double Amount);

        public void ShowGatewayName()
        {
            Console.WriteLine("Processing Payment through Gateway");
        }
    }

    class StripeGateway : PaymentGateway
    {
        public override void ProcessPayment(double Amount)
        {
            Console.WriteLine($"Processing payment through stripe:{Amount}");
        }
    }

    class PayPalGateway : PaymentGateway
    {
        public override void ProcessPayment(double Amount)
        {
            Console.WriteLine($"Processing payment through PayPal:{Amount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PaymentGateway paymentGateway;

            paymentGateway = new StripeGateway();

            paymentGateway.ShowGatewayName();
            paymentGateway.ProcessPayment(50000.0);

            paymentGateway = new PayPalGateway();

            paymentGateway.ShowGatewayName();
            paymentGateway.ProcessPayment(56000.0);
        }
    }
}
