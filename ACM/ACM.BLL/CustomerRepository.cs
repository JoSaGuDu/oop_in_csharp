using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    public class CustomerRepository
    {
        //Stablisshing a collaboration relationship with address repository to get sddress infromation
        //2.Create the AddresRepositoryInstance by calling the constructor
        public CustomerRepository() 
        {
            _addressRepository = new AddressRepository();
        }

        //1. Create a private property for the address repository object
        private AddressRepository _addressRepository { get; set; }

        ///<sumary>
        ///Retrieve one customer
        ///<sumary>
        public Customer Retrieve (int customerID)
        {
            //Collaboration relationship: CustomerRepository USES A Customer object to populate it wit info from database.
            Customer customer = new Customer(customerID);
            //TODO: code to get the costumer form the database

            //Temporary customer to work  with
            if (customerID == 1)
            {
                customer.EmailAddress = "jsgd@jsgd.ca";
                customer.FirstName = "Jose";
                customer.LastName = "Gutierrez";
                customer.AddressList = _addressRepository.RetrieveByCustomerId(customerID).ToList();

            }

            return customer;
        }

        ///<summary>
        ///Overload the Retrieve method for retreive informations for multiple customers
        ///</summary>
        ///<returns></returns>
        public List<Customer> Retrieve()//Same name diferent signature. Method overload because it perform similar functionalities and returns same type results than non overload method.
        {
            //TODO: Code to access the database and get many costumers

            return new List<Customer>();
        }

        ///<sumary>
        ///Saves the current customer
        ///<sumary>
        public bool save(Customer customer)
        {
            //Collaboration Relarionship: Repository --USES A-- entity class taking an instance of Customer to use the instance information  to save info into a database

            Customer newCustomer = new Customer();
            //TODO: code to save the new customer to the database
            return true;
        }


    }
}
