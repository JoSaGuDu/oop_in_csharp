using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    //Entity class
    public class Customer//Private by default added public to make it public
    {

        //Creating dabase generated Unique Identifiers
        public int CostumerId { get; private set; }
        //Using snippets
        public string EmailAddress { get; set; }


        //Backing field for Last name: Needed because the public property can be setted so we need to hold data somewhere.
        private string _lastName;//encapsulate (hide data) by maiking it private. Requires public accesors to make it public available.

        //C# Property
        public string LastName// If only avaiable for code inside project, use internal string LastName{}.
        {
            //Public accesors for _lastName field
            get//if not => write only property.
            {
                //Add any code to perform on the value before returned... such as validating accessing user, formating output, converting output...
                return _lastName;
            }
            set//if not => read only property.
            {
                //Add any code to perform on the value before stored such as validating input, formating and conveting input
                _lastName = value;
            }
        }

        //Shorthand definition
        //Optionally, if not additional code on accessors you can use AUTOIMPLEMENTED PROPERTIES which implicity define the backing field
        public string FirstName { get; set; }

        //Creating compund property
        public string FullName//no setter because no other code modify this property.
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                        {
                            fullName += ", ";
                        }

                    fullName += FirstName;
                }
                return fullName;
            }
        }

        //Creating a static: Bellons to the class rather than a specific instance. Callable with the ClassName.staticPropertyName
        public static int InstanceCounter { get; set; }

        //Methods

        ///<summary>
        ///Validates costumer data
        ///</summary>
        ///<returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

        ///<summary>
        ///Retrieve informations for a specific customer
        ///</summary>
        ///<returns></returns>
        public Customer Retrieve(int costumerId)
        {
            
            return new Customer();
        }

        ///<summary>
        ///Overload the Retrieve method for retreive informations for multiple customers
        ///</summary>
        ///<returns></returns>
        public List<Customer> Retrieve()//Same nakme diferent signature.
        {

            return new List<Customer>();
        }

        ///<summary>
        ///Save or add a new customer to the DB
        ///</summary>
        ///<returns></returns>
        public bool Save()
        {

            return true;
        }
    }

    
}

