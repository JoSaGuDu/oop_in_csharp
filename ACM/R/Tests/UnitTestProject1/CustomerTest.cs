using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLL.Test

{
    [TestClass]//Basic unit test calss
    public class CustomerTest
    {
        [TestMethod]//Basic unit test method. Each metod is a teste we want to perform in the clas tested.
        public void FullNameTestValid()
        {
            //--Arrange: Instatiation of the class to be tested
            Customer testCustomer = new Customer();
            //--Act
            //--Assert
        }
    }
}
