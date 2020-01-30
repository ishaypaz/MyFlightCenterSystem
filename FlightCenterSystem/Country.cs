using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
    public class Country :IPoco
    {
        public int _ID;
        public string COUNTRY_NAME;

        public Country()
        {

        }
        public Country(int id,string countryName)
        {
            this._ID = id;
            this.COUNTRY_NAME = countryName;
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
