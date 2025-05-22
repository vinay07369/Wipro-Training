using System;

class PhoneBook
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        phonebook.Add("Vinay Kumar G", "7305291199");
        phonebook.Add("Sonu Kumar P", "8735442687");
        phonebook.Add("Sai Seshu D", "9873542617");

        foreach (var contact in phonebook)
        { 
            Console.WriteLine($"Name: {contact.Key} , PhoneNumber: {contact.Value}");
        }

        Console.Write("Enter the name:");
        string name = Console.ReadLine();

        if (phonebook.ContainsKey(name))
        {
            Console.WriteLine($"Phone Number of {name}: {phonebook[name]}");
        }
        else
        {
            Console.WriteLine($"Phone Number of {name} not Found in the Contact List");
        }
    }
}