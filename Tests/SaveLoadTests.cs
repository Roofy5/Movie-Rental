using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WypozyczalniaDLL;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class SaveLoadTests
    {
        private List<Client> Clients;
        private List<Movie> Movies;
        private List<Rental> Rentals;
        private List<Category> Categories;
        private List<PersonalData> Personals;

        private string filePath = "C:\\\\file.xml";


        [TestInitialize]
        public void Initial()
        {
            Clients = new List<Client>();
            Movies = new List<Movie>();
            Rentals = new List<Rental>();
            Categories = new List<Category>();
            Personals = new List<PersonalData>();

            PersonalData pers1 = new PersonalData("Michal", "Gucwa", DateTime.Today);
            Client client1 = new Client(pers1);
            Movie movie1 = new Movie("Film1", 1);
            Rental rent1 = new Rental(DateTime.Today, 5);

            Movie movie2 = new Movie("Film2", (decimal)25.99);
            Movie movie3 = new Movie("Film3", (decimal)100);
            Movie movie4 = new Movie("Film4", (decimal)100.5);
            Movie movie5 = new Movie("Film5", (decimal)5);
            Movie movie6 = new Movie("Film6", (decimal)50);

            CategoryChild.Instance.AddMovie(movie2);
            CategoryNew.Instance.AddMovie(movie2);
            CategoryNew.Instance.AddMovie(movie3);
            CategoryNew.Instance.AddMovie(movie4);
            CategoryNormal.Instance.AddMovie(movie5);
            CategoryChild.Instance.AddMovie(movie5);

            CategoryNormal.Instance.PointsPerDay = 1;
            CategoryChild.Instance.PointsPerDay = 2;
            CategoryNew.Instance.PointsPerDay = 3;

            CategoryChild.Instance.AddMovie(movie1);
            rent1.MoviesList.Add(movie1);
            client1.RentalList.Add(rent1);

            Clients.Add(client1);
            Movies.Add(movie1);
            Movies.Add(movie2);
            Movies.Add(movie3);
            Movies.Add(movie4);
            Movies.Add(movie5);
            Movies.Add(movie6);
            Rentals.Add(rent1);
            Personals.Add(pers1);
            Categories.Add(CategoryChild.Instance);
            Categories.Add(CategoryNew.Instance);
            Categories.Add(CategoryNormal.Instance);
        }

        [TestMethod]
        public void SaveLoad_SaveTest_Dictionares()
        {
            SaveLoadToXML test = new SaveLoadToXML(filePath);

            test.Save(Clients, Movies, Categories);

        }
    }
}
