using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WypozyczalniaDLL;

namespace Tests
{
    [TestClass]
    public class RentalTests
    {
        [TestMethod]
        public void Rental_ConstructorTest()
        {
            Rental rental = new Rental(new DateTime(2016, 11, 3), new DateTime(2016, 11, 13));

            Assert.AreEqual(new DateTime(2016, 11, 3), rental.RentDate);
            Assert.AreEqual(new DateTime(2016, 11, 13), rental.ReturnDate);
        }

        [TestMethod]
        public void Rental_ConstructorTest2()
        {
            Rental rental = new Rental(new DateTime(2016, 11, 3), 5);

            Assert.AreEqual(new DateTime(2016, 11, 3), rental.RentDate);
            Assert.AreEqual(new DateTime(2016, 11, 8), rental.ReturnDate);
        }

        [TestMethod]
        public void Rental_ConstructorTest3()
        {
            Rental rental = new Rental(DateTime.Today, 10);

            Assert.AreEqual(DateTime.Today, rental.RentDate);
            Assert.AreEqual(DateTime.Today.AddDays((int)10), rental.ReturnDate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Rental_ConstructorTest_WrongDate()
        {
            Rental rental = new Rental(new DateTime(2016,11,3), new DateTime(2016,11,2));

            Assert.Fail();
        }

    }
}
