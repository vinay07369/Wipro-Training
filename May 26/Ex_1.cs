using System;

interface IPaymentProcessor
{
    public void ProcessPayment(double amount);
}
abstract class PaymentGateway : IPaymentProcessor
{
    public string GatewayName { get; set; }
    public abstract void Validate();
    public abstract void ProcessPayment(double amount);
}
class RazorPay : PaymentGateway
{ 
    public override void Validate()
    {
        Console.WriteLine("Validating RazorPay payment gateway.");
    }
    public RazorPay()
    {
        GatewayName = "RazorPay";
    }
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment of {amount} through {GatewayName}.\n");
    }
}
class PayPal : PaymentGateway
{
    public override void Validate()
    {
        Console.WriteLine("Validating PayPal payment gateway.");
    }
    public PayPal()
    {
        GatewayName = "PayPal";
    }
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment of {amount} through {GatewayName}.\n");
    }
}
class Stripe : PaymentGateway
{
    public override void Validate()
    {
        Console.WriteLine("Validating Stripe payment gateway.");
    }
    public Stripe()
    {
        GatewayName = "Stripe";
    }
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment of {amount} through {GatewayName}.\n");
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<PaymentGateway> gateways = new List<PaymentGateway>
        {
            new RazorPay(),
            new PayPal(),
            new Stripe()
        };

        double[] amount = {1200.0, 1500.0, 2000.0};

        for (int i = 0; i < gateways.Count; i++)
        {
            PaymentGateway gateway = gateways[i];
            gateway.Validate();
            gateway.ProcessPayment(amount[i]);
        }
    }
}
