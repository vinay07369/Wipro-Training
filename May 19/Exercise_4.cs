using System;

// 1. Abstract class PaymentMethod
abstract class PaymentMethod
{
    public string MethodName;

    public abstract void ProcessPayment(decimal amount); // Abstract method

    public void ShowPaymentMethod() // Concrete method
    {
        Console.WriteLine($"Payment Method: {MethodName}");
    }
}

// 2. Derived class: CreditCardPayment
class CreditCardPayment : PaymentMethod
{
    public CreditCardPayment()
    {
        MethodName = "Credit Card";
    }

    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}

// 2. Derived class: UPIPayment
class UPIPayment : PaymentMethod
{
    public UPIPayment()
    {
        MethodName = "UPI";
    }

    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI payment of {amount}");
    }
}

// 3. Main Method
class Program
{
    static void Main(string[] args)
    {
        // Create objects using base class reference
        PaymentMethod payment1 = new CreditCardPayment();
        PaymentMethod payment2 = new UPIPayment();

        // Call methods for CreditCardPayment
        payment1.ShowPaymentMethod();
        payment1.ProcessPayment(1500.0m); // Polymorphism in action

        Console.WriteLine();

        // Call methods for UPIPayment
        payment2.ShowPaymentMethod();
        payment2.ProcessPayment(850.50m); // Polymorphism in action
    }
}