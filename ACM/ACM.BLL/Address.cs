using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        { 
            AddressID = addressId;
        }
        public int AddressID { get; private set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int Type { get; set; }

        /// <summary>
        /// Validates the addres data
        /// </summary>
        /// <param name="street"></param>
        /// <returns></returns>
        public bool Validate()
        {
            if (PostalCode == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }

}
