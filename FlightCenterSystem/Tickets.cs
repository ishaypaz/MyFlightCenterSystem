using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
    public class Tickets : IPoco
    {
        public int _ID;
        public int _FLIGHT_ID;
        public int _CUSTOMER_ID;

        public Tickets()
        {

        }
        public Tickets(int id,int flightID,int customerID)
        {
            this._ID = id;
            this._FLIGHT_ID = flightID;
            this._CUSTOMER_ID = customerID;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
