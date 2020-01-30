using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
    public class Flight : IPoco
    {
        public int ID { get; protected set; }

        public int AIRLINECOMPANY_ID { get; protected set; }

        public int ORIGIN_COUNTRY_CODE { get; protected set; }

        public int DESTINATION_COUNTRY_CODE { get; protected set; }

        public DateTime DEPARTURE_TIME { get; protected set; }

        public DateTime LANDING_TIME { get; protected set; }

        public int REMAINING_TICKETS { get; protected set; }
    }
}
