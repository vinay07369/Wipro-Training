using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Vinay", "Sai", "Raghul", "Anil", "Imran", "Naresh", "Suman"};

        UsingAnonymousMethods(names);

    }

    private static void UsingAnonymousMethods(string[] names)
    {

        Func<string, bool> filter = delegate (string s)
        {
            return s.Length == 5;
        };

        Func<string, string> extract = delegate (string s)
        {
            return s;
        };

        Func<string, string> project = delegate (string s)
        {
            return s.ToUpper();
        };

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
