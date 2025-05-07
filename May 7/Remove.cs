using System;
using System.Collections;

class Remove
{
    public static void Main(string[] args)
    { 
        ArrayList list = new ArrayList();

        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);

        list.Remove(42);   //Removes the element with the value 42
        list.RemoveAt(0);  //Removes the element at index 0

        Console.WriteLine("The Count After removal:" + list.Count); //output: 1

        foreach (var i in list)
        { 
             Console.WriteLine(i);       
        }

        Console.Read();
    }

}
    