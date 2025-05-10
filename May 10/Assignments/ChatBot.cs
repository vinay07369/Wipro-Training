using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class ChatBot
    {
        public void Respond(string Greeting)
        {
            Console.WriteLine($"Greetings of the day: {Greeting}");
            Console.WriteLine("-----------------------------------");
        }

        public void Respond(string Question, bool cf)
        {
            Console.WriteLine($"Question for the day: {Question}");
            Console.WriteLine($"Casual/Formal: {cf}");
            Console.WriteLine("-----------------------------------");
        }

        public void Respond(int numericalQuery)
        { 
            Console.WriteLine($"The Numerical Query: {numericalQuery}");
            Console.WriteLine("-----------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            ChatBot bot = new ChatBot();

            bot.Respond("Welcome to the ChatBot Application");
            bot.Respond("How can I help you?", true);
            bot.Respond(10);
        }
    }   
}
   