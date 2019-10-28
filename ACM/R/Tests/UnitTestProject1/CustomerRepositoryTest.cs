using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange: 
            //1.Instatiation of the class to be tested

            //Shortcut syntax to initialize objects: Object initializer
            var customerRepository = new CustomerRepository();

            //2.Set properties values if needed

            //3. Set the expected outcome
            var expectedCustomer = new Customer(1)
            {
                EmailAddress = "dnewsson@dsign.com",
                FirstName = "David",
                LastName = "Newsson",
            };
            //--Act: Perform the test operations
            var actualCostumer = customerRepository.Retrieve(1);

            //--Assert: Teste the outcome
            Assert.AreEqual(expectedCustomer.CostumerId, actualCostumer.CostumerId);
            Assert.AreEqual(expectedCustomer.EmailAddress, actualCostumer.EmailAddress);
            Assert.AreEqual(expectedCustomer.FirstName, actualCostumer.FirstName);
            Assert.AreEqual(expectedCustomer.LastName, actualCostumer.LastName);
        }
    }
}
