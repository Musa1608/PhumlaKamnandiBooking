using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiBooking.Business
{
    class Guest:Person
    {
        #region Class Info
        // Derived from the person class. 
        // This will represent guests of the Puhmla Kamnandi Hotels which may have a booking or not.
        // The guest will have a guestID representing the Primary key of the key when it comes to booking and as an identifier for the guest
        #endregion

        #region Data Members
        private int guestID;
        private string address;
        #endregion

        #region Property Methods
        public int getGuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        public string getAddress
        {
            get { return address; }
            set { address = value; }
        }
        #endregion

        #region Constructor
        public Guest(int ID)
        {
            guestID = ID;
        }
        #endregion
    }
}
