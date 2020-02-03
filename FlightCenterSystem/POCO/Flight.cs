using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
     class Flight : IPoco
    {
        public int ID { get;  set; }

        public int AIRLINECOMPANY_ID { get;  set; }

        public int ORIGIN_COUNTRY_CODE { get;  set; }

        public int DESTINATION_COUNTRY_CODE { get;  set; }

        public DateTime DEPARTURE_TIME { get;  set; }

        public DateTime LANDING_TIME { get;  set; }

        public int REMAINING_TICKETS { get;  set; }

        public Flight()
        {

        }
        public override int GetHashCode()
        {
            return this.ID;
        }
    }
 
    
}
