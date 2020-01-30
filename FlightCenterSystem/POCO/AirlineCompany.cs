using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
     class AirlineCompany: IPoco, IUser
    {

        public int ID { get;  set; }

        public string AIRLINE_NAME { get;  set; }

        public string USER_NAME { get;  set; }

        public string PASSWORD { get;  set; }

        public int COUNTRY_CODE { get;  set; }

        public AirlineCompany()
        {

        }

    }
}
