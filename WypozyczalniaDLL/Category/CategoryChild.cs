using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class CategoryChild : ICategory
    {
        private static CategoryChild instance;
        private static List<Movie> movies;
        private static int points;

        public static CategoryChild Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryChild();
                return instance;
            } 
        }

        public int PointsPerDay
        {
            get { return points; }
            set
            {
                RemovePointsForEachMovie(points);
                points = value;
                AddPointsForEachMovie(points);
            }
        }

        private CategoryChild()
        {
            movies = new List<Movie>();
            points = 0;
        }

        public void AddMovie(Movie movie)
        {
            if (movies.Contains(movie))
                return;
            movies.Add(movie);
            movie.Points += points;
        }

        public void RemoveMovie(Movie movie)
        {
            if (movies.Contains(movie))
                movies.Remove(movie);
        }

        public string ReturnCategory(Movie movie)
        {
            throw new NotImplementedException();
        }

        public List<Movie> ReturnListOfMovies()
        {
            return movies;
        }

        private void RemovePointsForEachMovie(int minusPoints)
        {
            foreach (Movie movie in movies)
                movie.Points -= minusPoints;
        }

        private void AddPointsForEachMovie(int addPoints)
        {
            foreach (Movie movie in movies)
                movie.Points += addPoints;
        }
    }
}
