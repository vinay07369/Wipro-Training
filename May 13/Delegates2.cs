using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace Delegates_Practice
{
    //Define a custom delegate that has a string parameter and returns void
    delegate void CustomDel(string s);

    class TestClass
    {
        //Define two methods that have same signature as CustomDel
        static void Hello(string s)
        { 
            Console.WriteLine($"Hello, {s}!");
        }

        static void GoodBye(string s)
        {
            Console.WriteLine($"GoodBye, {s}!");
        }

        static void Main(string[] args)
        {
            //Declare instance of custom delegates
            CustomDel hiDel, byeDel, multiDel;

            hiDel = Hello;

            //create the delegate object byeDel that references the method GoodBye
            byeDel = GoodBye;

            //The two delegate, hiDel and byeDel are combined to form multiDel
            //MULTICAST DELEGATES - SIMPLE INVOCATION
            multiDel = hiDel + byeDel;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("Vinay");

            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("Vinay");

            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("Vinay");


        }
    }
}