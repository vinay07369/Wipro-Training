using System;
using System.Collections;

class Insert
{
    public static void Main(string[] args)
    { 
        ArrayList list = new ArrayList();

        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);

        list.Insert(1, "Inserted");
        Console.WriteLine("The element Inserted at Index 1:" + list[1]); //output: Inserted

        foreach (var i in list)
        { 
             Console.WriteLine(i);       
        }
    }

}