using System;

interface ISupportTicket
{ 
    public void CreateTicket(string issue);
    public void ResolveTicket(int ticketId);
}
class EmailSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating Ticket via Email : {issue} ");
    }

    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving Ticket {ticketId} via Email");
    }
}
class PhoneSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating Ticket via Phone : {issue} ");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving Ticket {ticketId} via Phone");
    }
}
class Program
{
    static void Main()
    {
        ISupportTicket support;
        
        support = new EmailSupport();
        support.CreateTicket("kumargv896@gmail.com");
        support.ResolveTicket(1234);

        support = new PhoneSupport();
        support.CreateTicket("7305291199");
        support.ResolveTicket(0718);
    }
}