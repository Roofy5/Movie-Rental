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
            Category kategoria = CategoryChild.Instance;
            Category kategoria2 = CategoryChild.Instance;

            Assert.AreSame(kategoria, kategoria2);
        }
        [TestMethod]
        public void Category_AddMovies()
        {
            Category kategoria = CategoryChild.Instance;
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
            Category kategoria = CategoryChild.Instance;
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
            Category kategoria = CategoryChild.Instance;
            kategoria.AddMovie(new Movie("asdasd", 13));
            Assert.AreEqual(true, kategoria.ReturnListOfMovies().Count > 1); //Z poprzednich testow tez dodalo filmy
        }
        [TestMethod]
        public void Category_RemoveMovie()
        {
            Movie film = new Movie("123", 1);

            Category kategoria = CategoryChild.Instance;
            kategoria.AddMovie(film);
            kategoria.AddMovie(film);

            Category kategoriaWinnymMiejscu = CategoryChild.Instance;
            kategoriaWinnymMiejscu.RemoveMovie(film);

            Assert.AreEqual(false, CategoryChild.Instance.ReturnListOfMovies().Contains(film));            
        }
        [TestMethod]
        public void Category_RemoveNotContainedMovie()
        {
            Movie film = new Movie("123", 1);

            Category kategoria = CategoryChild.Instance;
            kategoria.RemoveMovie(film);

            Assert.AreEqual(false, CategoryChild.Instance.ReturnListOfMovies().Contains(film));
        }
        [TestMethod]
        public void Category_TwoCategories()
        {
            Movie film = new Movie("asda", 1);

            Category dzieciece = CategoryChild.Instance;
            Category nowe = CategoryNew.Instance;

            dzieciece.AddMovie(film);

            Assert.AreEqual(false, nowe.ReturnListOfMovies().Contains(film));
        }
        [TestMethod]
        public void Category_TwoCategories2()
        {
            Category dzieciece = CategoryChild.Instance;
            Category nowe = CategoryNew.Instance;
            
            Assert.AreNotSame(dzieciece.ReturnListOfMovies(), nowe.ReturnListOfMovies());
        }
        [TestMethod]
        public void Category_TwoCategories_PointsCheck()
        {
            Category dzieciece = CategoryChild.Instance;
            Category nowe = CategoryNew.Instance;

            dzieciece.PointsPerDay = 10;
            CategoryNew.Instance.PointsPerDay = 20;
            
            Assert.AreEqual(10, CategoryChild.Instance.PointsPerDay);
            Assert.AreEqual(20, CategoryNew.Instance.PointsPerDay);
        }
        [TestMethod]
        public void Category_CategoriesNames()
        {
            Category dzieciece = CategoryChild.Instance;
            Category nowe = CategoryNew.Instance;
            Category normalne = CategoryNormal.Instance;

            StringAssert.Equals("Child", dzieciece.ReturnCategoryName());
            StringAssert.Equals("Normal", normalne.ReturnCategoryName());
            StringAssert.Equals("New", nowe.ReturnCategoryName());
        }
        [TestMethod]
        public void Category_ThreeCategories()
        {
            Category dzieciece = CategoryChild.Instance;
            Category nowe = CategoryNew.Instance;
            Category normalne = CategoryNormal.Instance;

            Movie film1 = new Movie("Film1", 1);
            Movie film2 = new Movie("Film2", 2);
            Movie film3 = new Movie("Film3", 3);

            dzieciece.AddMovie(film1);
            nowe.AddMovie(film2);
            normalne.AddMovie(film3);

            Assert.AreEqual(true, dzieciece.ReturnListOfMovies().Contains(film1));
            Assert.AreEqual(true, CategoryChild.Instance.ReturnListOfMovies().Contains(film1));

            Assert.AreEqual(true, nowe.ReturnListOfMovies().Contains(film2));
            Assert.AreEqual(true, CategoryNew.Instance.ReturnListOfMovies().Contains(film2));

            Assert.AreEqual(true, normalne.ReturnListOfMovies().Contains(film3));
            Assert.AreEqual(true, CategoryNormal.Instance.ReturnListOfMovies().Contains(film3));
        }
        [TestMethod]
        public void Category_ThreeCategories2()
        {
            Category dzieciece = CategoryChild.Instance;
            Category nowe = CategoryNew.Instance;
            Category normalne = CategoryNormal.Instance;

            Movie film1 = new Movie("Film1", 1);
            Movie film2 = new Movie("Film2", 2);
            Movie film3 = new Movie("Film3", 3);

            dzieciece.AddMovie(film1);
            nowe.AddMovie(film2);
            normalne.AddMovie(film3);

            Assert.AreEqual(false, dzieciece.ReturnListOfMovies().Contains(film2));
            Assert.AreEqual(false, dzieciece.ReturnListOfMovies().Contains(film3));
            Assert.AreEqual(false, CategoryChild.Instance.ReturnListOfMovies().Contains(film2));
            Assert.AreEqual(false, CategoryChild.Instance.ReturnListOfMovies().Contains(film3));

            Assert.AreEqual(false, nowe.ReturnListOfMovies().Contains(film1));
            Assert.AreEqual(false, nowe.ReturnListOfMovies().Contains(film3));
            Assert.AreEqual(false, CategoryNew.Instance.ReturnListOfMovies().Contains(film1));
            Assert.AreEqual(false, CategoryNew.Instance.ReturnListOfMovies().Contains(film3));

            Assert.AreEqual(false, normalne.ReturnListOfMovies().Contains(film2));
            Assert.AreEqual(false, normalne.ReturnListOfMovies().Contains(film1));
            Assert.AreEqual(false, CategoryNormal.Instance.ReturnListOfMovies().Contains(film2));
            Assert.AreEqual(false, CategoryNormal.Instance.ReturnListOfMovies().Contains(film1));
        }
        [TestMethod]
        public void Category_ThreeCategories_PointsCheck()
        {
            Category dzieciece = CategoryChild.Instance;
            Category nowe = CategoryNew.Instance;
            Category normalne = CategoryNormal.Instance;

            Movie film1 = new Movie("Film1", 1);
            Movie film2 = new Movie("Film2", 2);
            Movie film3 = new Movie("Film3", 3);

            dzieciece.PointsPerDay = 1;
            nowe.PointsPerDay = 2;
            normalne.PointsPerDay = 3;

            dzieciece.AddMovie(film1);
            nowe.AddMovie(film2);
            normalne.AddMovie(film3);

            Assert.AreEqual(1, film1.Points);
            Assert.AreEqual(2, film2.Points);
            Assert.AreEqual(3, film3.Points);

            CategoryNew.Instance.PointsPerDay = 20;
            normalne.PointsPerDay = 30;

            Assert.AreEqual(1, film1.Points);
            Assert.AreEqual(20, film2.Points);
            Assert.AreEqual(30, film3.Points);

        }
        [TestMethod]
        public void Category_MovieInThreeCategories()
        {
            Category dzieciece = CategoryChild.Instance;
            Category nowe = CategoryNew.Instance;
            Category normalne = CategoryNormal.Instance;

            Movie film1 = new Movie("Film1", 1);

            CategoryChild.Instance.PointsPerDay = 10;
            nowe.PointsPerDay = 20;
            normalne.PointsPerDay = 30;

            dzieciece.AddMovie(film1);
            nowe.AddMovie(film1);
            CategoryNormal.Instance.AddMovie(film1);

            Assert.AreEqual(60, film1.Points);
        }
        [TestMethod]
        public void Category_MovieInThreeCategories_AndRemove()
        {
            Category dzieciece = CategoryChild.Instance;
            Category nowe = CategoryNew.Instance;
            Category normalne = CategoryNormal.Instance;

            Movie film1 = new Movie("Film1", 1);

            CategoryChild.Instance.PointsPerDay = 10;
            nowe.PointsPerDay = 20;
            normalne.PointsPerDay = 30;

            dzieciece.AddMovie(film1);
            nowe.AddMovie(film1);
            CategoryNormal.Instance.AddMovie(film1);

            Assert.AreEqual(60, film1.Points);

            nowe.RemoveMovie(film1);

            Assert.AreEqual(true, dzieciece.ReturnListOfMovies().Contains(film1));
            Assert.AreEqual(true, CategoryNormal.Instance.ReturnListOfMovies().Contains(film1));
            Assert.AreEqual(false, nowe.ReturnListOfMovies().Contains(film1));
            Assert.AreEqual(40, film1.Points);
        }
    }
}
