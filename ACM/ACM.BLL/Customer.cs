using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    public class Customer//Private by default added public to make it public
    {

        //Creating dabase generated Unique Identifiers
        public int CostumerId { get; private set; }
        //Using snippets
        public string EmailAddress { get; set; }


        //Backing field for Last name: NEede because the public property can be setted so we need to hold data somewhere.
        private string _lastName;//encapsulate by maiking it private. Requires public accesors to make it public available.

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
        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }
    }
}
