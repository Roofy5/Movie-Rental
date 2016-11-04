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
        [TestMethod]
        public void Movie_Categories()
        {
            Movie film = new Movie("Leon zawodowiec", (decimal)100.50);
            Category normalne = CategoryNormal.Instance;

            normalne.AddMovie(film);

            Assert.AreEqual(true, film.Categories.Contains(CategoryNormal.Instance));
            Assert.AreEqual(false, film.Categories.Contains(CategoryChild.Instance));
        }
        [TestMethod]
        public void Movie_Categories2()
        {
            Movie film = new Movie("Leon zawodowiec", (decimal)100.50);
            Category normalne = CategoryNormal.Instance;

            normalne.AddMovie(film);
            CategoryChild.Instance.AddMovie(film);

            Assert.AreEqual(true, film.Categories.Contains(CategoryNormal.Instance));
            Assert.AreEqual(true, film.Categories.Contains(CategoryChild.Instance));

            Category dzieciece = CategoryChild.Instance;
            dzieciece.RemoveMovie(film);

            Assert.AreEqual(true, film.Categories.Contains(CategoryNormal.Instance));
            Assert.AreEqual(false, film.Categories.Contains(CategoryChild.Instance));
        }
        [TestMethod]
        public void Movie_Categories_Names()
        {
            Movie film = new Movie("Leon zawodowiec", (decimal)100.50);
            Category normalne = CategoryNormal.Instance;

            normalne.AddMovie(film);
            CategoryChild.Instance.AddMovie(film);

            string categories = "";
            foreach (Category category in film.Categories)
            {
                categories += category.ReturnCategoryName();
            }

            StringAssert.Equals("NormalChild", categories);

            Category dzieciece = CategoryChild.Instance;
            dzieciece.RemoveMovie(film);

            categories = "";
            foreach (Category category in film.Categories)
            {
                categories += category.ReturnCategoryName();
            }

            StringAssert.Equals("Normal", categories);
        }
    }
}
