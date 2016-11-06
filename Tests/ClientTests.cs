using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WypozyczalniaDLL;

namespace Tests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void Client_Constructor()
        {
            Client klient = new Client(new PersonalData("Michał", "Gucwa", new DateTime(1995, 7, 13)));

            StringAssert.Equals("Michał", klient.PersonalData.Name);
            StringAssert.Equals("Gucwa", klient.PersonalData.Name);
            Assert.AreEqual(1995, klient.PersonalData.BirthDate.Year);
            Assert.AreEqual(7, klient.PersonalData.BirthDate.Month);
            Assert.AreEqual(13, klient.PersonalData.BirthDate.Day);
            Assert.AreEqual(0, klient.Points);
            Assert.AreEqual(0, klient.RentalList.Count);
        }
        [TestMethod]
        public void Client_SingleRentail_CalculatePoints()
        {
            Client klient = new Client(new PersonalData("Michał", "Gucwa", new DateTime(1995, 7, 13)));
            Rental rental = new Rental(DateTime.Now, 10);
            Movie film1 = new Movie("asd", 10);

            CategoryNew.Instance.AddMovie(film1);
            CategoryNew.Instance.PointsPerDay = 3;
            rental.MoviesList.Add(film1);
            klient.RentalList.Add(rental);

            klient.CalculatePoint();

            Assert.AreEqual(30, klient.Points);
        }
        [TestMethod]
        public void Client_SingleRentail_MultiMovies_CalculatePoints()
        {
            Client klient = new Client(new PersonalData("Michał", "Gucwa", new DateTime(1995, 7, 13)));
            Rental rental = new Rental(DateTime.Now, 10);
            Movie film1 = new Movie("asd", 10);
            Movie film2 = new Movie("asd", 20);
            Movie film3 = new Movie("asd", 30);

            CategoryNew.Instance.AddMovie(film1);
            CategoryNew.Instance.AddMovie(film2);
            CategoryNew.Instance.PointsPerDay = 3;
            CategoryChild.Instance.AddMovie(film3);
            CategoryChild.Instance.AddMovie(film2);
            CategoryChild.Instance.PointsPerDay = 2;

            rental.MoviesList.Add(film1);
            rental.MoviesList.Add(film2);
            rental.MoviesList.Add(film3);
            klient.RentalList.Add(rental);

            //film1: New: 3 * 10 = 30pts
            //film2: New, Child: 3 * 10 + 2 * 10 = 50pts
            //film3: Child: 2 * 10 = 20pts

            klient.CalculatePoint();

            Assert.AreEqual(100, klient.Points);
        }
        [TestMethod]
        public void Client_MultiRentail_MultiMovies_CalculatePoints()
        {
            Client klient = new Client(new PersonalData("Michał", "Gucwa", new DateTime(1995, 7, 13)));
            Rental rental = new Rental(DateTime.Now, 10);
            Rental rental2 = new Rental(DateTime.Now, 3);
            Movie film1 = new Movie("asd", 10);
            Movie film2 = new Movie("asd", 20);
            Movie film3 = new Movie("asd", 30);

            CategoryNew.Instance.AddMovie(film1);
            CategoryNew.Instance.AddMovie(film2);
            CategoryNew.Instance.PointsPerDay = 3;
            CategoryChild.Instance.AddMovie(film3);
            CategoryChild.Instance.AddMovie(film2);
            CategoryChild.Instance.PointsPerDay = 2;

            rental.MoviesList.Add(film1);
            rental.MoviesList.Add(film2);
            rental.MoviesList.Add(film3);
            rental2.MoviesList.Add(film2);
            rental2.MoviesList.Add(film3);
            klient.RentalList.Add(rental);
            klient.RentalList.Add(rental2);

            //film1: New: 3 * 10 = 30pts
            //film2: New, Child: 3 * 10 + 2 * 10 = 50pts
            //film3: Child: 2 * 10 = 20pts

            //film2: New, Child: 3 * 3 + 2 * 3 = 15pts
            //film3: Child: 2 * 3 = 6pts

            klient.CalculatePoint();

            Assert.AreEqual(121, klient.Points);
        }
        [TestMethod]
        public void Client_CalculatePrice()
        {
            Client klient = new Client(new PersonalData("Michał", "Gucwa", new DateTime(1995, 7, 13)));
            Rental rental = new Rental(DateTime.Now, 10);
            Rental rental2 = new Rental(DateTime.Now, 5);
            Movie film1 = new Movie("asd", 10);
            Movie film2 = new Movie("asd", 20);
            Movie film3 = new Movie("asd", (decimal)3.55);

            rental.MoviesList.Add(film1);
            rental.MoviesList.Add(film2);
            rental2.MoviesList.Add(film3);

            klient.RentalList.Add(rental);
            klient.RentalList.Add(rental2);

            decimal price = 0;
            foreach (Rental rent in klient.RentalList)
            {
                price += rent.CalculatePrice();
            }

            //film1: 10 * 10 = 100
            //film2: 20 * 10 = 200
            //film3: 3.55 * 5 = 17,75

            Assert.AreEqual((decimal)317.75, price);
        }
    }
}
