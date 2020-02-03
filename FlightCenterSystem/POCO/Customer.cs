using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
     class Customer : IPoco,IUser
    {
        public int ID { get;  set; }

        public string FIRST_NAME { get;  set; }

        public string LAST_NAME { get;  set; }

        public string USER_NAME { get;  set; }

        public string PASSWORD { get;  set; }

        public string ADDRESS { get;  set; }

        public string PHONE_NO { get;  set; }

        public string CREDIT_CARD_NUMBER { get;  set; }

        public Customer()
        {

        }
        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
