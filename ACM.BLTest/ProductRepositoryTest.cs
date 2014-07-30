using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "SunFlowers",
                ProductDescription = "Assorted Size",
                CurrentPrice = 15.96M
            };

            var actual = productRepository.Retrieve(2);

            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
