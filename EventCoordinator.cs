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
    class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        RSVPManager rsvpMan;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int rsvpIdSeed, int maxEvents)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
            rsvpMan = new RSVPManager(rsvpIdSeed);
        }

        //customer related methods
        public bool addCustomer(string fname, string lname, string phone)
        {
            return custMan.addCustomer(fname, lname, phone);
        }

        public string customerList()
        {
            return custMan.getCustomerList();
        }

        public Customer GetCustomer(int id)
        {
            return custMan.getCustomer(id);
        }

        public string getCustomerInfoById(int id)
        {
            return custMan.getCustomerInfo(id);
        }
        public bool deleteCustomer(int id)
        {
            return custMan.deleteCustomer(id);
        }

        // Event related methods
        public bool addEvent(string name, string venue, Date eventDate, int maxAttendee)
        {
            return eventMan.addEvent(name, venue, eventDate, maxAttendee);
        }

        public string eventList()
        {
            return eventMan.getEventList();
        }

        public Event GetEvent(int id)
        {
            return eventMan.getEvent(id);
        }

        public string getEventInfoById(int id)
        {
            return eventMan.getEventInfo(id);
        }

        //RSVP related methods
        public bool addRSVP(Customer c, Event e)
        {
            return rsvpMan.addRSVP(c, e);
        }

        public string rsvpList()
        {
            return rsvpMan.getRSVPList();
        }
    }

}
