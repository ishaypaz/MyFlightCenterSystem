using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
     class Country :IPoco
    {
        public int ID { get; set; }

        public int COUNTRY_NAME { get;  set; }

        public Country()
        {

        }
        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
