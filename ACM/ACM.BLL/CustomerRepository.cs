using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    public class CustomerRepository
    {
        ///<sumary>
        ///Retrieve one customer
        ///<sumary>
        public Customer Retrieve (int customerID)
        {
            Customer customer = new Customer(customerID);
            //TODO: code to get the costumer form the database

            //Temporary customer to work  with
            if (customerID == 1)
            {
                customer.EmailAddress = "dnewsson@dsign.com";
                customer.FirstName = "David";
                customer.LastName = "Newsson";

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
            Customer newCustomer = new Customer();
            //TODO: code to save the new customer to the database
            return true;
        }


    }
}
