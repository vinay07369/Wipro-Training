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

        // checks if a specific name exists..
        if (names.Contains("Vinay Kumar G"))
            names.RemoveAt(1); // remove the second name based on index
        else
            Console.WriteLine("Name doesn't exists!"); // if the name not found

        foreach (string name in names)
        {
            Console.WriteLine(name); // displays the final list
        }
    }
}
    
