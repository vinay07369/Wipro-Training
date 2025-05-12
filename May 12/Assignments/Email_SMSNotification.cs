using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Notification
    {
        public abstract void Send();
        public void ShowType()
        {
            Console.WriteLine("Sending Notification");
        }
    }

    class EmailNotification : Notification
    {
        public override void Send()
        {
           Console.WriteLine("Sending Email Notification");
        }
    }

    class SMSNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Sending SMS Notification");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notification notification;

            notification = new EmailNotification(); // creating an object for emial using Notification reference

            notification.ShowType();
            Console.WriteLine("-----------------");
            notification.Send();

            notification = new SMSNotification(); // creating an object for emial using Notification reference
            notification.ShowType();
            Console.WriteLine("-----------------");
            notification.Send();

        }
    }

}
