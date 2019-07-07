using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BLL;
using System.Collections;


namespace ACM.BLL.Test

{
    [TestClass]//Basic unit test calss
    public class CustomerTest
    {
        [TestMethod]//Basic unit test method. Each metod is a test we want to perform in the clas tested.
        public void FullNameTestValid()
        {
            //--Arrange: 
            //1.Instatiation of the class to be tested

            /*Customer testCustomer = new Customer();
            //2.Set properties values if needed
            testCustomer.FirstName = "Tester";
            testCustomer.LastName = "Thetester";
            *///Reemplaced by the shorcut syntax

            //Shortcut syntax to initialize objects: Object initializer
            Customer testCustomer = new Customer
            {
                //2.Set properties values if needed
                FirstName = "Tester",
                LastName = "Thetester"
            };
            //3. Set the expected outcome
            string expectedValue = "Thetester, Tester";

            //--Act: Perform the test operations
            string actualValue = testCustomer.FullName;

            //--Assert: Teste the outcome
            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]//This must be added in order to the test be recognized.
        public void FullNameTestFirstNameEmpty()
        {
            //--Arrange: 
            //1.Instatiation of the class to be tested
            //Shortcut syntax to initialize objects: Object initializer
            Customer testCustomer = new Customer
            {
                //2.Set properties values if needed
                LastName = "Thetester"
            };
            //3. Set the expected outcome
            string expectedValue = "Thetester";

            //--Act: Perform the test operations
            string actualValue = testCustomer.FullName;

            //--Assert: Teste the outcome
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]//This must be added in order to the test be recognized.
        public void FullNameTestLastNameEmpty()
        {
            //--Arrange: 
            //1.Instatiation of the class to be tested
            //Shortcut syntax to initialize objects: Object initializer
            Customer testCustomer = new Customer
            {
                //2.Set properties values if needed
                FirstName = "Tester",
                
            };
            //3. Set the expected outcome
            string expectedValue = "Tester";

            //--Act: Perform the test operations
            string actualValue = testCustomer.FullName;

            //--Assert: Teste the outcome
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]//This must be added in order to the test be recognized.
        public void staticPropTestInstanceCounter()
        {
            //--Arrange: 
            //1.Instatiation of the class to be tested
            Customer testCustomer1 = new Customer();
            Customer testCustomer2 = new Customer();
            Customer testCustomer3 = new Customer();

            //Set properties values if needed
            testCustomer1.FirstName = "Tester";
            Customer.InstanceCounter += 1;

            testCustomer2.FirstName = "Tester2";
            Customer.InstanceCounter += 1;

            testCustomer3.FirstName = "Tester3";
            Customer.InstanceCounter += 1;

            //3. Set the expected outcome
            int expectedValue = 3;

            //--Act: Perform the test operations
            int actualValue = Customer.InstanceCounter;

            //--Assert: Teste the outcome
            Assert.AreEqual(expectedValue, actualValue);
        }


    }
}
