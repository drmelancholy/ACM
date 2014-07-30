using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = Convert.ToDateTime("2014-07-21 14:10:10")
            };

            var actual = orderRepository.Retrieve(10);

            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.OrderID, actual.OrderID);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            
        }
    }
}
