using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Vinay", "Sai", "Raghul", "Anil", "Imran", "Naresh", "Suman"};

        UsingLinqFunctions(names);

    }

    private static void UsingLinqFunctions(string[] names)
    {

        Func<string, bool> filter = s => s.Length == 5;
        Func<string, string> extract = s => s;
        Func<string, string> project = s => s.ToUpper();

        IEnumerable<string> query = names
                                        .Where(filter)
                                        .OrderBy(extract)
                                        .Select(project);

        foreach (string item in query)
        {
            Console.WriteLine(item);
        }

        Console.Read();
    }
}
