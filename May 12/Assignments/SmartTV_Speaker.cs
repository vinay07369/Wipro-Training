using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IDeviceControl
    {
        void TurnOn();

        void TurnOff();
    }

    class SmartTV : IDeviceControl
    {
        public void TurnOn()
        {
            Console.WriteLine("Smart TV is now ON");
        }

        public void TurnOff()
        { 
            Console.WriteLine("Smart TV is now OFF");
        }
    }

    class Speaker : IDeviceControl
    {
        public void TurnOn()
        {
            Console.WriteLine("Speaker is now ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Speaker is now OFF");
        }
    }

    class Program
    {
        static void Main()
        {
            IDeviceControl control;

            Console.WriteLine("SmartTV Object ");
            Console.WriteLine("-------------------");

            control = new SmartTV(); // object creation for SmartTV using IDeviceControl reference

            control.TurnOn();
            control.TurnOff();

            Console.WriteLine("Speaker Object ");
            Console.WriteLine("-------------------");

            control = new Speaker(); // object creation for Speaker using IDeviceControl reference

            control.TurnOn();
            control.TurnOff();
        }
    }
}