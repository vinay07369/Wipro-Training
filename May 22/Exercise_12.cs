using System;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>()
        { 
            "Akash","Sathish","Vinay","Sai","Arun","Elango","Sonu","Kishore","Sanjay","Naveen"
        };

        var vowelNames = names.Where(name => "AEIOU".Contains(char.ToUpper(name[0])))
                              .ToList();

        Console.WriteLine("Names Starting with Vowels:");
        foreach (var name in vowelNames)
        { 
            Console.WriteLine(name);
        }
    }
}