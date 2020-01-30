using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
    public class Country :IPoco
    {
        public int ID { get;protected set; }

        public int COUNTRY_NAME { get; protected set; }

        public Country()
        {

        }
    }
}
