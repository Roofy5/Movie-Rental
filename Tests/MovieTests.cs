using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WypozyczalniaDLL;

namespace Tests
{
    [TestClass]
    public class MovieTests
    {
        [TestMethod]
        public void Movie_Constructor()
        {
            Movie film = new Movie("Leon zawodowiec", (decimal)100.50);

            StringAssert.Equals("Leon zawodowiec", film.Name);
            Assert.AreEqual((decimal)100.50, film.Price);
            Assert.AreEqual(0, film.Points);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Movie_Constructor_WrongPrice()
        {
            Movie film = new Movie("Leon zawodowiec", (decimal)-53.13);

            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Movie_WrongPrice()
        {
            Movie film = new Movie("Leon zawodowiec", (decimal)100.50);

            film.Price = -3;

            Assert.Fail();
        }
        [TestMethod]
        public void Movie_Price0()
        {
            Movie film = new Movie("Leon zawodowiec", (decimal)100.50);

            film.Price = 0;

            Assert.AreEqual(0, film.Price);
        }
    }
}
