using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WypozyczalniaDLL;

namespace Tests
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void Category_FewCategoriesObjects()
        {
            ICategory kategoria = CategoryChild.Instance;
            ICategory kategoria2 = CategoryChild.Instance;

            Assert.AreSame(kategoria, kategoria2);
        }
        [TestMethod]
        public void Category_AddMovies()
        {
            ICategory kategoria = CategoryChild.Instance;
            CategoryChild.Instance.PointsPerDay = 10;

            Movie film1 = new Movie("asd", (decimal)10.5);
            Movie film2 = new Movie("asd", (decimal)5.5);
            Movie film3 = new Movie("asd", (decimal)3);

            kategoria.AddMovie(film1);
            kategoria.AddMovie(film2);
            kategoria.AddMovie(film3);

            Assert.AreEqual(10, film1.Points);
            Assert.AreEqual(10, film2.Points);
            Assert.AreEqual(10, film3.Points);
        }
        [TestMethod]
        public void Category_ChangePointsForCategory()
        {
            ICategory kategoria = CategoryChild.Instance;
            CategoryChild.Instance.PointsPerDay = 10;

            Movie film1 = new Movie("asd", (decimal)10.5);
            Movie film2 = new Movie("asd", (decimal)5.5);
            Movie film3 = new Movie("asd", (decimal)3);

            kategoria.AddMovie(film1);
            kategoria.AddMovie(film2);
            kategoria.AddMovie(film3);

            CategoryChild.Instance.PointsPerDay = 5;
            //kategoria.PointsPerDay = 5; //to samo co powyzej

            Assert.AreEqual(5, film1.Points);
            Assert.AreEqual(5, film2.Points);
            Assert.AreEqual(5, film3.Points);
        }
        [TestMethod]
        public void Category_NumberOfMovies()
        {
            ICategory kategoria = CategoryChild.Instance;
            kategoria.AddMovie(new Movie("asdasd", 13));
            Assert.AreEqual(true, kategoria.ReturnListOfMovies().Count > 1); //Z poprzednich testow tez dodalo filmy
        }
        [TestMethod]
        public void Category_RemoveMovie()
        {
            Movie film = new Movie("123", 1);

            ICategory kategoria = CategoryChild.Instance;
            kategoria.AddMovie(film);
            kategoria.AddMovie(film);

            ICategory kategoriaWinnymMiejscu = CategoryChild.Instance;
            kategoriaWinnymMiejscu.RemoveMovie(film);

            Assert.AreEqual(false, CategoryChild.Instance.ReturnListOfMovies().Contains(film));            
        }
        [TestMethod]
        public void Category_RemoveNotContainedMovie()
        {
            Movie film = new Movie("123", 1);

            ICategory kategoria = CategoryChild.Instance;
            kategoria.RemoveMovie(film);

            Assert.AreEqual(false, CategoryChild.Instance.ReturnListOfMovies().Contains(film));
        }
    }
}
