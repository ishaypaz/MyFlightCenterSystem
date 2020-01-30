using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
    public class Tickets : IPoco
    {

        public int ID { get; protected set; }

        public int FLIGHT_ID { get; protected set; }

        public int CUSTOMER_ID { get; protected set; }


    }
}
