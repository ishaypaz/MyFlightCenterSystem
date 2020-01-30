using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
    public class AirlineCompany: IPoco, IUser
    {

        public int ID { get; protected set; }

        public string AIRLINE_NAME { get; protected set; }

        public string USER_NAME { get; protected set; }

        public string PASSWORD { get; protected set; }

        public int COUNTRY_CODE { get; protected set; }

        public AirlineCompany()
        {

        }

    }
}
