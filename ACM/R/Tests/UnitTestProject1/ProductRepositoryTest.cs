using System;
using ACM.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLL.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetriveProduct()
        {
            //--Arrange: 
            //1.Instatiation of the class to be tested
            var productRepository = new ProductRepository();
            //2.Set properties values if needed

            //3. Set the expected outcome
            var expectedProduct = new Product(1)
            {
                Name = "Klepsydra",
                Description = "Klepsydra timepiece is an outstanding achievement and unlike anything else on the market. Each Klepsydra contains over 2.8 million silver- or gold-plated stainless-steel nanoballs which measure the elapsed time. A full cycle takes 30 minutes from the start.",
                CurrentPrice = 4725m

            };

            //--Act: Perform the test operations
            var actualProduct = productRepository.Retrieve(1);

            //--Assert: Test the Outcome
            Assert.AreEqual(expectedProduct.ProductId, actualProduct.ProductId);
            Assert.AreEqual(expectedProduct.Name, actualProduct.Name);
            Assert.AreEqual(expectedProduct.Description, actualProduct.Description);
        }
    }
}
