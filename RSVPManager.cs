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
    class RSVPManager
    {
        List<RSVP> rsvp = new List<RSVP>();
        private int rsvpId;

        public RSVPManager(int rsvpID)
        {
            rsvpId = rsvpID;
        }

        public bool addRSVP(Customer c, Event e)
        {
            if(e.getNumAttendees() == 0) { return false; }
            if(e.getNumAttendees() < e.getMaxAttendees()) 
            {
                rsvp.Add(new RSVP(rsvpId, c, e));
                ++rsvpId;
                return true;
            }
            return false;
        }

        public string getRSVPList()
        {
            string s = "RSVP List:";
            for (int x = 0; x < rsvp.Count(); x++)
            {
                s += "\nDate: " + rsvp[x].getDate() + "\nRSVP Number: " + rsvp[x].getRSVPID() + "\nCustomer Name: " + rsvp[x].getCustomer().getFirstName() + " " + rsvp[x].getCustomer().getLastName()
                    + "\nEvent ID: " + rsvp[x].getEvent().getEventId();
            }
            return s;
        }
    }
}

