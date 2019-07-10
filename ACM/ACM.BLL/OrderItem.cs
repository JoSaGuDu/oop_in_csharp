using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    class OrderItem
    {

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
        

        //Constructor
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId, int productId, decimal purchasePrice)
        {
            OrderItemId = orderItemId;
            ProductId = productId;
            PurchasePrice = purchasePrice;
        }

        //Methods


        ///<summary>
        ///Validates product info
        ///</summary>
        ///<returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (PurchasePrice == null) isValid = false;
            return isValid;
        }

        ///<summary>
        ///Retrieve informations for a specific product
        ///</summary>
        ///<returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
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
