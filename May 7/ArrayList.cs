using System;
using System.Collections;

class ArrayList
{
    public static void Main(string[] args)
    { 
        ArrayList list = new ArrayList();

        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);

        foreach (var i in list)
        { 
             Console.WriteLine(i);       
        }
    }

}