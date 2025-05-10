using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class SmartDevice
    {
        public string DeviceName;

        public bool PowerStatus;

        public void TogglePower(string DeviceName, bool PowerStatus)
        {
            Console.WriteLine($"Device Name:{DeviceName}");
            Console.WriteLine($"Power Status:{PowerStatus}");
        }      
    }

    class SmartLight : SmartDevice
    {
        public int Brightness;

        public void changeBrightness(int Brightness)
        { 
            Console.WriteLine($"Brightness is changed to:{Brightness}%");
            
        }
    }

    class SmartThermostat : SmartDevice
    {
        public double Temperature;

        public void changeTemperature(double Temperature) 
        { 
            Console.WriteLine($"Current Temperature: {Temperature} degree Celcius");         
        }
    }

    class Program
    {
        static void Main()
        { 
            SmartLight light = new SmartLight();

            SmartThermostat smartThermostat = new SmartThermostat();

            light.TogglePower("Voltas AC", true);

            light.changeBrightness(50);

            smartThermostat.changeTemperature(24.0); 
        }
    }
