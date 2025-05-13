using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace Delegates_Practice
{
    delegate void CustomDel(string s);

    class TestClass
    {
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
            CustomDel hiDel, byeDel, multiDel, multiMinusDel;

            hiDel = Hello;

            byeDel = GoodBye;

            multiDel = hiDel + byeDel;

            //Remove hiDel from the multiCast delegate , leaving byeDel,
            //which calls only the method GoodBye..
            multiMinusDel = multiDel - hiDel;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("Vinay");

            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("Vinay");

            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("Vinay");

            Console.WriteLine("Invoking delegate multiMinusDel:");
            multiMinusDel("Vinay");

        }
    }
}