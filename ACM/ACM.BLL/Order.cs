using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    class Order
    {

        public int OrderId { get; private set; }

        public string Customer { get; set; }
    
        public DateTimeOffset? OrderDate { get; set; }

        public List<Product> OrderItems { get; set; }
       
        public decimal? CurrentPrice { get; set; }

        //Constructor
        public Order()
        {

        }

        public Order(int ordetId)
        {

            OrderId = ordetId;

        }

        //Methods


        ///<summary>
        ///Validates order info
        ///</summary>
        ///<returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Customer)) isValid = false;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

        ///<summary>
        ///Retrieve informations for a specific product
        ///</summary>
        ///<returns></returns>
        public Order Retrieve(int orderID)
        {
            return new Order();
        }
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        ///<summary>
        ///Save or add a new product to the DB
        ///</summary>
        ///<returns></returns>
        public bool Save()
        {

            return true;
        }
    }
}
