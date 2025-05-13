using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface ITransport
    {
        public void Start()
        {
            Console.WriteLine("Starting the Transport");
        }
        public void Stop()
        {
            Console.WriteLine("Stoping the Transport");
        }
    }

    class Bus : ITransport
    {
        public void Start()
        {
            Console.WriteLine("Bus is starting");    
        }
        public void Stop()
        {
            Console.WriteLine("Bus is stopping");
        }
    }

    class Train : ITransport
    {
        public void Start()
        {
            Console.WriteLine("Train is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Train is stopping");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ITransport transport;

            transport = new Bus();

            transport.Start();
            transport.Stop();

            transport = new Train();

            transport.Start();
            transport.Stop();
        }
    }
}
