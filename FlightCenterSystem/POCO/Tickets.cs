using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
     class Tickets : IPoco
    {

        public int ID { get;  set; }

        public int FLIGHT_ID { get;  set; }

        public int CUSTOMER_ID { get;  set; }

        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
