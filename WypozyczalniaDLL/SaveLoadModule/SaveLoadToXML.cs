using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace WypozyczalniaDLL
{
    public class SaveLoadToXML : ISaveLoad
    {
        private string filepath;
        private XDocument document;
        private XElement root;

        public XDocument Document
        {
            get { return document; }
        }

        private Dictionary<int, Category> Categories;
        private Dictionary<int, Movie> Movies;
        private Dictionary<int, Rental> Rentals;
        private Dictionary<int, Client> Clients;
        private Dictionary<int, PersonalData> Personals;

        public SaveLoadToXML(string filepath)
        {
            this.filepath = filepath;
            document = new XDocument();
            Categories = new Dictionary<int, Category>();
            Movies = new Dictionary<int, Movie>();
            Rentals = new Dictionary<int, Rental>();
            Clients = new Dictionary<int, Client>();
            Personals = new Dictionary<int, PersonalData>();
        }

        public bool Save(List<Client> clients, List<Movie> movies, List<Category> categories)
        {
            try
            {
                ResetDictionaries();
                CreateStructureOfXml();
                LoadCategoriesDictionary(categories);
                LoadMoviesDictionary(movies);
                LoadClientsDictionary(clients);
                foreach (Client cl in clients)
                {
                    Personals.Add(Personals.Keys.Count, cl.PersonalData);
                    LoadRentalsDictionary(cl.RentalList);
                }

                SavePersonalDatas();
                SaveMovies();
                SaveCategories();
                SaveRentals();
                SaveClients();

                document.Save(filepath);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool Load(out List<Client> clients, out List<Movie> movies, out List<Category> categories)
        {
            try
            {
                ResetDictionaries();
            }
            catch (Exception)
            {
                clients = null;
                movies = null;
                categories = null;
                return false;
            }
            clients = null;
            movies = null;
            categories = null; //USUNAC TO!!!
            return true;
        }

        private void CreateStructureOfXml()
        {
            XElement root = new XElement("Wypozyczalnia");
            XElement movies = new XElement("Movies");
            XElement categories = new XElement("Categories");
            XElement rentals = new XElement("Rentals");
            XElement personalDatas = new XElement("PersonalDatas");
            XElement clients = new XElement("Clients");

            root.Add(movies);
            root.Add(categories);
            root.Add(rentals);
            root.Add(personalDatas);
            root.Add(clients);
            document.Add(root);
            this.root = document.Element("Wypozyczalnia");
        }
        private void ResetDictionaries()
        {
            Categories.Clear();
            Movies.Clear();
            Rentals.Clear();
            Clients.Clear();
            Personals.Clear();
        }

        private void LoadCategoriesDictionary(List<Category> categories)
        {
            for (int i = 0; i < categories.Count; i++)
                Categories.Add(i, categories[i]);
        }
        private void LoadMoviesDictionary(List<Movie> movies)
        {
            for (int i = 0; i < movies.Count; i++)
                Movies.Add(i, movies[i]);
        }
        private void LoadRentalsDictionary(List<Rental> rentals)
        {
            for (int i = 0; i < rentals.Count; i++)
                Rentals.Add(i + Rentals.Keys.Count, rentals[i]);
        }
        private void LoadClientsDictionary(List<Client> clients)
        {
            for (int i = 0; i < clients.Count; i++)
                Clients.Add(i, clients[i]);
        }

        private void SavePersonalDatas()
        {
            foreach (KeyValuePair<int, PersonalData> pers in Personals)
            {
                XElement personalsDatas = root.Element("PersonalDatas");
                XElement singlePersonal = new XElement("Personal");

                XElement name = new XElement("Name");
                name.Value = pers.Value.Name;

                XElement surname = new XElement("Surname");
                surname.Value = pers.Value.Surname;

                XElement dateBirth = new XElement("BirthDate");
                dateBirth.Value = pers.Value.BirthDate.ToString();

                singlePersonal.SetAttributeValue("id", pers.Key);
                singlePersonal.Add(name);
                singlePersonal.Add(surname);
                singlePersonal.Add(dateBirth);

                personalsDatas.Add(singlePersonal);
            }
        }
        private void SaveMovies()
        {
            foreach (KeyValuePair<int, Movie> movie in Movies)
            {
                XElement moviesElement = root.Element("Movies");
                XElement singleMovie = new XElement("Movie");

                XElement name = new XElement("Name");
                name.Value = movie.Value.Name;

                XElement price = new XElement("Price");
                price.Value = movie.Value.Price.ToString();

                XElement points = new XElement("Points");
                points.Value = movie.Value.Points.ToString();

                singleMovie.SetAttributeValue("id", movie.Key);
                singleMovie.Add(name);
                singleMovie.Add(price);
                singleMovie.Add(points);

                moviesElement.Add(singleMovie);
            }
        }
        private void SaveCategories()
        {
            foreach (KeyValuePair<int, Category> cat in Categories)
            {
                XElement categoryElement = root.Element("Categories");
                XElement singleCategory = new XElement("Category");

                XElement name = new XElement("Name");
                name.Value = cat.Value.ReturnCategoryName();

                XElement points = new XElement("PointsPerDay");
                points.Value = cat.Value.PointsPerDay.ToString();

                XElement movies = new XElement("Movies");

                foreach (Movie movie in cat.Value.ReturnListOfMovies())
                {
                    XElement movieElement = new XElement("Movie");
                    foreach (KeyValuePair<int, Movie> moviePair in Movies)
                    {
                        if (moviePair.Value == movie)
                        {
                            movieElement.Value = moviePair.Key.ToString();
                            break;
                        }
                    }
                    movies.Add(movieElement);
                }

                singleCategory.SetAttributeValue("id", cat.Key);
                singleCategory.Add(name);
                singleCategory.Add(points);
                singleCategory.Add(movies);

                categoryElement.Add(singleCategory);
            }
        }
        private void SaveRentals()
        {
            foreach (KeyValuePair<int, Rental> rent in Rentals)
            {
                XElement rentalElement = root.Element("Rentals");
                XElement singleRental = new XElement("Rental");
                
                XElement rentDate = new XElement("RentDate");
                rentDate.Value = rent.Value.RentDate.ToString();

                XElement returnDate = new XElement("ReturnDate");
                returnDate.Value = rent.Value.ReturnDate.ToString();

                XElement movies = new XElement("Movies");

                foreach (Movie movie in rent.Value.MoviesList)
                {
                    XElement movieElement = new XElement("Movie");
                    foreach (KeyValuePair<int, Movie> moviePair in Movies)
                    {
                        if (moviePair.Value == movie)
                        {
                            movieElement.Value = moviePair.Key.ToString();
                            break;
                        }
                    }
                    movies.Add(movieElement);
                }

                singleRental.SetAttributeValue("id", rent.Key);
                singleRental.Add(rentDate);
                singleRental.Add(returnDate);
                singleRental.Add(movies);

                rentalElement.Add(singleRental);
            }
        }
        private void SaveClients()
        {
            foreach (KeyValuePair<int, Client> clientPair in Clients)
            {
                XElement clientsElement = root.Element("Clients");
                XElement singleClient = new XElement("Client");

                XElement points = new XElement("Points");
                points.Value = clientPair.Value.Points.ToString();

                XElement personalData = new XElement("PersonalData");

                foreach (KeyValuePair<int, PersonalData> pers in Personals)
                {
                    if (pers.Value == clientPair.Value.PersonalData)
                    {
                        personalData.Value = pers.Key.ToString();
                        break;
                    }
                }

                XElement rentals = new XElement("Rentnals");

                foreach (Rental rental in clientPair.Value.RentalList)
                {
                    XElement rentalElement = new XElement("Rental");
                    foreach (KeyValuePair<int, Rental> rentalPair in Rentals)
                    {
                        if (rentalPair.Value == rental)
                        {
                            rentalElement.Value = rentalPair.Key.ToString();
                            break;
                        }
                    }
                    rentals.Add(rentalElement);
                }

                singleClient.SetAttributeValue("id", clientPair.Key);
                singleClient.Add(points);
                singleClient.Add(personalData);
                singleClient.Add(rentals);

                clientsElement.Add(singleClient);
            }
        }

        private void LoadMovies()
        {
            XElement moviesElement = root.Element("Movies");

            foreach (XElement singleMovie in moviesElement.Descendants())
            {
                int id = int.Parse(singleMovie.Attribute("id").Value);
                string name = singleMovie.Element("Name").Value;
                decimal price = decimal.Parse(singleMovie.Element("Price").Value, System.Globalization.CultureInfo.InvariantCulture);
                int points = int.Parse(singleMovie.Element("Points").Value, System.Globalization.CultureInfo.InvariantCulture);

                Movie newMovie = new Movie(name, price);
                newMovie.Points = points;

                Movies.Add(id, newMovie);
            }
        }
    }
}
