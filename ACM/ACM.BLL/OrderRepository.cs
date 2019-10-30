using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLL
{
    public class OrderRepository
    {
        ///<summary>
        ///Retrieve one specific order
        ///</summary>
        ///<returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            //TODO: code that retrieves an order
            if (orderId == 1)
            {
                order.Customer = "JSGD";
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year,4,14,10,00,00, new TimeSpan(7,0,0));
            }
            return order;
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
            //TODO: Code that save a oreder in database
            return true;
        }
    }
}
