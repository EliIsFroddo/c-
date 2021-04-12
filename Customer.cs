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
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;

        public Customer(int cId, string fname, string lname, string ph)
        {
            bookings = 0;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhone() { return phone; }
        public int getNumBookings() { return bookings; }
        public override string ToString()
        {
            string s = "Customer " + customerId;
            s = s + "\nName: " + firstName + " " + lastName;
            s = s + "\nPhone: " + phone;
            s = s + "\nBookings: " + bookings;

            return s;
        }

    }
}
