using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLL.Test
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //--Arrange: 
            //1.Instatiation of the class to be tested
            var orderRepository = new OrderRepository();
            //2.Set properties values if needed

            //3. Set the expected outcome
            var expectedOrder = new Order(1)
            {
                Customer = "JSGD",
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //--Act: Perform the test operations
            var actualOrderRepository = orderRepository.Retrieve(1);

            //--Assert
        }
  
    }
}
