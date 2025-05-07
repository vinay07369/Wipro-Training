using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    { 
        ArrayList names = new ArrayList();
        names.Add("Vinay Kumar G");
        names.Add("Sai seshu");
        names.Add("Karthik B");
        names.Add("Suresh K");
        names.Add("Pawan P");

        if (names.Contains("Vinay Kumar G"))
            names.RemoveAt(1);
        else
            Console.WriteLine("Name not Found!");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
    
