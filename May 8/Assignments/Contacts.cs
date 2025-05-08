using System;
using System.Collections;

namespace dictionary
{
    class Program
    {
        static void Main()
        {
            //Create a dictionary
            Dictionary<string,string> contacts = new Dictionary<string,string>();

            //Add contacts
            contacts.Add("Vinay","7305291199");
            contacts.Add("Sai", "7563782981");
            contacts.Add("Saran","6355267189");
            contacts.Add("Ram", "9873972199");
            contacts.Add("Shankar", "8749758493");

            //Update phonenumber for a specific name 
            contacts["Sai"] = "75637829673";

            if (contacts.ContainsKey("Ram"))
            {
                Console.WriteLine("Ram..Name exists..");
            }

            Console.WriteLine("All Contacts:");

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}