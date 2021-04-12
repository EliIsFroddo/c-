using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Elijah Flood 101253293
//Taric Folkes 101252980
//Maxim Pasarov 101248391

namespace COMP2129A1
{
    class RSVP
    {
        private string venue;
        private int rsvpID;
        private string date;
        private Customer customer;
        private Event eventRSVP;

        public RSVP(int id, Customer cust, Event e)
        {
            customer = cust;
            eventRSVP = e;
            venue = e.getVenue();
            rsvpID = id;
            date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }

        public Customer getCustomer() { return customer; }
        public Event getEvent() { return eventRSVP; }
        public string getVenue() { return venue; }
        public string getDate() { return date; }
        public int getRSVPID() { return rsvpID; }

        public void toString()
        {
            Console.WriteLine("Date: {0}\nRSVP Number: {1}\n{2}\n{3}", 
                getDate(), getRSVPID(), getCustomer().ToString(), getEvent().ToString());
        }
    }
}
