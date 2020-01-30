using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterSystem
{
    public class Customer : IPoco,IUser
    {
        public int _ID;
        public string _FIRST_NAME;
        public string _LAST_NAME;
        public string _USER_NAME;
        public string _PASSWORD;
        public string _ADDRESS;
        public string _PHONE_NO;
        public string _CREDIT_CARD_NUMBER;

        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string userName,string password,string address,string phoneNo,string creditCardNumber)
        {
            this._ID = id;
            this._FIRST_NAME = firstName;
            this._LAST_NAME = lastName;
            this._USER_NAME = userName;
            this._PASSWORD = password;
            this._ADDRESS = address;
            this._PHONE_NO = phoneNo;
            this._CREDIT_CARD_NUMBER = creditCardNumber;

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
