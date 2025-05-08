using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main()
        {
            ArrayList names = new ArrayList();

            //Adding the names of the students
            names.Add("Vinay");
            names.Add("Saran");
            names.Add("Ram");
            names.Add("Sai");
            names.Add("Dinesh");

            //Remove name by value
            names.RemoveAt(2);

            //display the list of names after removal
            Console.WriteLine("After Removal:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //check if the given name exists
            if (names.Contains("Saran"))
            {
                Console.WriteLine("Saram name Exists");
            }
        }
    }
}


    