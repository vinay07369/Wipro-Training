using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Vinay", "Sai", "Raghul", "Anil", "Imran", "Naresh", "Suman"};

        UsingLinq(names);

    }

    private static void UsingLinq(string[] names)
    {

        IEnumerable<string> query = names
                                        .Where(s => s.Length == 5) // functions
                                        .OrderBy(s => s)
                                        .Select(s => s.ToUpper());

        foreach (string item in query)
        {
            Console.WriteLine(item);
        }

        Console.Read();
    }
}