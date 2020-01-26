using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    public class AddressRepository
    {
        ///<sumary>
        ///Retrieve one addres
        ///<sumary>
        public Address Retrieve(int addressId)
        {
            //Collaboration relationship: AddressRepository --USES A-- Address object to populate it with info from database.
            Address address = new Address(addressId);
            //TODO: code to get the address form the database

            //Temporary address to work  with
            if (addressId == 1)
            {
                address.StreetLine1 = "3350 Avenue Linton";
                address.StreetLine2 = "App 207";
                address.City = "Montreal";
                address.State = "Quebec";
                address.PostalCode = "H3S1T2";
                address.Country = "Canada";
                address.Type = 1;
            }
            return address;
        }  
        
        ///<summary>
        ///Retrieve all addresses for a coustumer
        ///</summary>
        public IEnumerable<Address>RetrieveByCustomerId(int coutmerId)//IEnumerable is the recomended type to retrive a secuence of data
        {
            var AddressList = new List<Address>();

            Address address = new Address(1)
            {
                StreetLine1 = "3350 Avenue Linton",
                StreetLine2 = "App 207",
                City = "Montreal",
                State = "Quebec",
                PostalCode = "H3S1T2",
                Country = "Canada",
                Type = 1
            };
            AddressList.Add(address);

            address = new Address(2)
            {
                StreetLine1 = "400 Rue Montfort",
                StreetLine2 = "Suit J2051",
                City = "Montreal",
                State = "Quebec",
                PostalCode = "H4S2T3",
                Country = "Canada",
                Type = 2
            };
            AddressList.Add(address);
            return AddressList;
        }

        ///<sumary>
        ///Saves the current address
        ///<sumary>
        public bool save(Address address)
        {
            //Collaboration Relarionship: Repository --USES A-- entity class taking an instance of Address to use the instance information  to save info into a database

            Address newAddress = new Address();
            //TODO: code to save the new customer to the database
            return true;
        }
    }
}
