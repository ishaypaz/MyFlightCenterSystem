using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
    public class Customer : IPoco,IUser
    {
        public int ID { get; protected set; }

        public string FIRST_NAME { get; protected set; }

        public string LAST_NAME { get; protected set; }

        public string USER_NAME { get; protected set; }

        public string PASSWORD { get; protected set; }

        public string ADDRESS { get; protected set; }

        public string PHONE_NO { get; protected set; }

        public string CREDIT_CARD_NUMBER { get; protected set; }

        public Customer()
        {

        }
    }
}
