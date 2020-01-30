using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
    public class Flight : IPoco
    {
        public int _ID;
        public int AIRLINECOMPANY_ID;
        public int _ORIGIN_COUNTRY_CODE;
        public int _DESTINATION_COUNTRY_CODE;
        public DateTime _DEPARTURE_TIME;
        public DateTime _LANDING_TIME;
        public int _REMAINING_TICKETS;

        public Tickets()
        {

        }

        public Tickets(int id, int airlineCompanyID, int originCountryCode, int destinationCountryCode, DateTime departureTime, DateTime landingTime, int remainingTickets)
        {
            this._ID = id;
            this.AIRLINECOMPANY_ID = airlineCompanyID;
            this._ORIGIN_COUNTRY_CODE = originCountryCode;
            this._DESTINATION_COUNTRY_CODE = destinationCountryCode;
            this._DEPARTURE_TIME = departureTime;
            this._LANDING_TIME = landingTime;
            this._REMAINING_TICKETS = remainingTickets;

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
