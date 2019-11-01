using System;
using System.Collections.Generic;
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
                EmailAddress = "jsgd@jsgd.ca",
                FirstName = "Jose",
                LastName = "Gutierrez"
            };
            //--Act: Perform the test operations
            var actualCostumer = customerRepository.Retrieve(1);

            //--Assert: Teste the outcome
            Assert.AreEqual(expectedCustomer.CostumerId, actualCostumer.CostumerId);
            Assert.AreEqual(expectedCustomer.EmailAddress, actualCostumer.EmailAddress);
            Assert.AreEqual(expectedCustomer.FirstName, actualCostumer.FirstName);
            Assert.AreEqual(expectedCustomer.LastName, actualCostumer.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //--Arrange: 
            //1.Instatiation of the class to be tested

            //Shortcut syntax to initialize objects: Object initializer
            var customerRepository = new CustomerRepository();
            //2.Set properties values if needed

            //3. Set the expected outcome
            var expectedCustomer = new Customer(1)
            {
                EmailAddress = "jsgd@jsgd.ca",
                FirstName = "Jose",
                LastName = "Gutierrez",
                AddressList = new List<Address>()
                                    {
                                        new Address(1)
                                        {
                                            StreetLine1 = "3350 Avenue Linton",
                                            StreetLine2 = "App 207",
                                            City = "Montreal",
                                            State = "Quebec",
                                            PostalCode = "H3S1T2",
                                            Country = "Canada",
                                            Type = 1
                                        },
                                        new Address(2)
                                        {
                                            StreetLine1 = "400 Rue Montfort",
                                            StreetLine2 = "Suit J2051",
                                            City = "Montreal",
                                            State = "Quebec",
                                            PostalCode = "H4S2T3",
                                            Country = "Canada",
                                            Type = 2
                                        }
                                   }
            };
            //--Act: Perform the test operations
            var actualCustomer = customerRepository.Retrieve(1);

            //--Assert: Teste the outcome
            Assert.AreEqual(expectedCustomer.CostumerId, actualCustomer.CostumerId);
            Assert.AreEqual(expectedCustomer.EmailAddress, actualCustomer.EmailAddress);
            Assert.AreEqual(expectedCustomer.FirstName, actualCustomer.FirstName);
            Assert.AreEqual(expectedCustomer.LastName, actualCustomer.LastName); 
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expectedCustomer.AddressList[i].StreetLine1, actualCustomer.AddressList[i].StreetLine1);
                Assert.AreEqual(expectedCustomer.AddressList[i].StreetLine2, actualCustomer.AddressList[i].StreetLine2);
                Assert.AreEqual(expectedCustomer.AddressList[i].City, actualCustomer.AddressList[i].City);
                Assert.AreEqual(expectedCustomer.AddressList[i].State, actualCustomer.AddressList[i].State);
                Assert.AreEqual(expectedCustomer.AddressList[i].PostalCode, actualCustomer.AddressList[i].PostalCode);
                Assert.AreEqual(expectedCustomer.AddressList[i].Country, actualCustomer.AddressList[i].Country);
                Assert.AreEqual(expectedCustomer.AddressList[i].Type, actualCustomer.AddressList[i].Type    );

            }

        }
    }
}
