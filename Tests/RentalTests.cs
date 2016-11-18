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
        [TestMethod]
        public void Rental_CalculatePrice()
        {
            Rental rental = new Rental(DateTime.Today, 3);
            Movie film = new Movie("Leon", 10);
            rental.MoviesList.Add(film);

            Assert.AreEqual(30, rental.CalculatePrice());
        }
        [TestMethod]
        public void Rental_CalculatePrice_0Movies()
        {
            Rental rental = new Rental(DateTime.Today, 3);

            Assert.AreEqual(0, rental.CalculatePrice());
        }
        [TestMethod]
        public void Rental_CalculatePrice_MoreMovies()
        {
            Rental rental = new Rental(DateTime.Today, 2);
            Movie film = new Movie("Leon", 10);
            Movie film2 = new Movie("Harry Potter", 13);
            Movie film3 = new Movie("Kaczka Dziwaczka xD", 5);
            rental.MoviesList.Add(film);
            rental.MoviesList.Add(film2);
            rental.MoviesList.Add(film3);

            Assert.AreEqual(56, rental.CalculatePrice());
        }
        [TestMethod]
        public void Rental_CalculatePrice_LongRental()
        {
            Rental rental = new Rental(DateTime.Today, 50);
            Movie film = new Movie("Leon", 10);
            rental.MoviesList.Add(film);

            Assert.AreEqual(500, rental.CalculatePrice());
        }
        [TestMethod]
        public void Rental_CalculatePrice_RentalBetweenTwoMonths()
        {
            // Pytanie jak liczyc dni - czy uwzgledniac date zwrotu jako dzien wypozyczony?
            Rental rental = new Rental(new DateTime(2016, 12, 31), new DateTime(2017, 1, 3));
            Movie film = new Movie("Leon", 10);
            rental.MoviesList.Add(film);

            Assert.AreEqual(30, rental.CalculatePrice());
        }
        [TestMethod]
        public void Rental_CalculatePrice_SameDay()
        {
            Rental rental = new Rental(DateTime.Today, DateTime.Today);
            Movie film = new Movie("Leon", 10);
            rental.MoviesList.Add(film);

            Assert.AreEqual(0, rental.CalculatePrice());
        }
        [TestMethod]
        public void Rental_CalculatePoints()
        {
            Rental rental = new Rental(DateTime.Today, 5);
            Movie film = new Movie("Leon", 10);
            rental.MoviesList.Add(film);

            Assert.AreEqual(0, rental.CalculatePoints());

            CategoryNew.Instance.AddMovie(film);
            CategoryNew.Instance.PointsPerDay = 2;

            Assert.AreEqual(10, rental.CalculatePoints());
        }
        [TestMethod]
        public void Rental_CalculatePoints_2Movies()
        {
            Rental rental = new Rental(DateTime.Today, 5);
            Movie film = new Movie("Leon", 10);
            Movie film2 = new Movie("Leonasd", 20);

            CategoryNew.Instance.PointsPerDay = 2;
            Category kategoria = CategoryNormal.Instance;
            kategoria.PointsPerDay = 1;
            
            CategoryNew.Instance.AddMovie(film);
            kategoria.AddMovie(film2);

            rental.MoviesList.Add(film);
            rental.MoviesList.Add(film2);

            Assert.AreEqual(15, rental.CalculatePoints());
        }
        [TestMethod]
        public void Rental_CalculatePoints_MoviesInMultiCategories()
        {
            Rental rental = new Rental(DateTime.Today, 5);
            Movie film = new Movie("Leon", 10);
            Movie film2 = new Movie("Leonasd", 20);

            CategoryNew.Instance.PointsPerDay = 2;
            Category kategoria = CategoryNormal.Instance;
            kategoria.PointsPerDay = 1;

            CategoryNew.Instance.AddMovie(film);
            kategoria.AddMovie(film2);

            rental.MoviesList.Add(film);
            rental.MoviesList.Add(film2);

            Assert.AreEqual(15, rental.CalculatePoints());

            CategoryNormal.Instance.AddMovie(film);
            Assert.AreEqual(20, rental.CalculatePoints());
        }
        [TestMethod]
        public void Rental_CalculatePoints_SecondStrategy()
        {
            Rental rental = new Rental(DateTime.Today, 5, new PointsOneDayStrategy());
            Movie film = new Movie("Leon", 10);
            Movie film2 = new Movie("Leonasd", 20);

            CategoryNew.Instance.PointsPerDay = 20;
            Category kategoria = CategoryNormal.Instance;
            kategoria.PointsPerDay = 1;

            CategoryNew.Instance.AddMovie(film);
            kategoria.AddMovie(film2);

            rental.MoviesList.Add(film);
            rental.MoviesList.Add(film2);

            Assert.AreEqual(27, rental.CalculatePoints());
        }
        [TestMethod]
        public void Rental_CalculatePoints_SecondStrategy_OnlyOneDay()
        {
            Rental rental = new Rental(DateTime.Today, 1, new PointsOneDayStrategy());
            Movie film = new Movie("Leon", 10);
            Movie film2 = new Movie("Leonasd", 20);
            
            CategoryNew.Instance.AddMovie(film);
            CategoryNormal.Instance.AddMovie(film2);

            rental.MoviesList.Add(film);
            rental.MoviesList.Add(film2);

            Assert.AreEqual(15, rental.CalculatePoints());
        }
    }
}
