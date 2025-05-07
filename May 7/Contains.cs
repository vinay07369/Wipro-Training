using System;
using System.Collections;

class contains
{
    public static void Main(string[] args)
    { 
        ArrayList list = new ArrayList();

        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);

        if (list.Contains("Apple"))
            Console.WriteLine("Found 'Apple' in the list");
        else
            Console.WriteLine("Not Found");

        foreach (var i in list)
        { 
             Console.WriteLine(i);       
        }

        Console.Read();
    }

}