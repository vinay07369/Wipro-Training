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
        static void Hello(string s)
        { 
            Console.WriteLine($"Hello, {s}!");
        }

        static void Main(string[] args)
        {
            CustomDel hiDel;

            hiDel = Hello;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("Vinay");
        }
    }
}

//Output:-
//Invoking delegate hiDel:
//Hello, Vinay!