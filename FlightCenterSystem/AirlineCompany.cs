using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
    public class AirlineCompany: IPoco, IUser
    {
        public int _ID;
        public string _AIRLINE_NAME;
        public string _USER_NAME;
        public string _PASSWORD;
        public int _COUNTRY_CODE;

        public AirlineCompany()
        {

        }

        public AirlineCompany(int id,string airlineName,string userName,string password,int countryCode)
        {
            this._ID = id;
            this._AIRLINE_NAME = airlineName;
            this._USER_NAME = userName;
            this._PASSWORD = password;
            this._COUNTRY_CODE = countryCode;
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
