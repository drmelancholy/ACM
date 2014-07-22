using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void fullNameTestValid()
        {
            Customer customer = new Customer();

            customer.firstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void fullNameFirstNameEmpty()
        {
            Customer customer = new Customer();
            customer.LastName = "Baggins";

            string expected = "Baggins";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void fullNameLastNameEmpty()
        {
            Customer customer = new Customer();

            customer.firstName = "Bilbo";

            string expected = "Bilbo";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.firstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.firstName = "Frodo";
            Customer.InstanceCount++;

            var c3 = new Customer();
            c3.firstName = "Rosie";
            Customer.InstanceCount++;

            Assert.AreEqual(3, Customer.InstanceCount);

        }

        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.eMailAddress = "fbaggins@hobbiton.me";

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer();
            customer.eMailAddress = "fbaggins@hobbiton.me";

            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

    }
}
