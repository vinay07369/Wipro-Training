using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class TicketBooking
    {
        public abstract void BookTicket(int seats);

        public void BookingInfo() => Console.WriteLine("Booking Tickets...");
        
    }

    class BusBooking : TicketBooking
    {
        public override void BookTicket(int seats)
        {
            Console.WriteLine($"Booking {seats} Bus Tickets");
        }
    }

    class FlightBooking : TicketBooking
    {
        public override void BookTicket(int seats)
        {
            Console.WriteLine($"Booking {seats} Flight Tickets");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TicketBooking ticketBooking;

            ticketBooking = new BusBooking();
            ticketBooking.BookingInfo();
            Console.WriteLine("==============");
            ticketBooking.BookTicket(10);

            ticketBooking = new FlightBooking();
            ticketBooking.BookingInfo();
            Console.WriteLine("==============");
            ticketBooking.BookTicket(5);
        }
    }
    
}