using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    public class Order
    {

        public int OrderId { get; private set; }
        //Stablish a composition relationship by Id referencing the customer id value and not all the costumer details.
        // public string Customer { get; set; }//Composition by property that load all the class details.
        public int CostumerId { get; set; }//Composition by ID
        public DateTimeOffset? OrderDate { get; set; }// ? is a short for Nullable<DateTimeOffset> => is nullable.
        //Stablish a composition relationship by Id referencing the shipping addres id value and not allt he costumer details.
        // public string ShippingAddress { get; set; }//Composition by property that load all the class details.
        public int ShippingSaddressId { get; set; }//Composition by ID

        public List<Product> OrderItems { get; set; }//Composition by property reference 
       
        public decimal? CurrentPrice { get; set; }

        //Constructor
        public Order(): this(0)
        {

        }

        public Order(int ordetId)
        {
            OrderId = ordetId;
            OrderItems = new List<Product>();

        }

        //Methods


        ///<summary>
        ///Validates order info
        ///</summary>
        ///<returns></returns>
        public bool Validate()
        {
            var isValid = true;

            //if (string.IsNullOrWhiteSpace(CostumerID)) isValid = false;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

        //MOVED TO THE REPOSITORY
        /////<summary>
        /////Retrieve informations for a specific product
        /////</summary>
        /////<returns></returns>
        //public Order Retrieve(int orderID)
        //{
        //    return new Order();
        //}
        //public List<Order> Retrieve()
        //{
        //    return new List<Order>();
        //}

        /////<summary>
        /////Save or add a new product to the DB
        /////</summary>
        /////<returns></returns>
        //public bool Save()
        //{

        //    return true;
        //}
    }
}
