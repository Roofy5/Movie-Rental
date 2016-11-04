using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public abstract class Category
    {
        protected List<Movie> movies;
        protected int points;

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

        public void AddMovie(Movie movie)
        {
            if (movies.Contains(movie))
                return;
            movies.Add(movie);
            movie.Points += points;
            if(!movie.Categories.Contains(this))
                movie.Categories.Add(this);
        }

        public void RemoveMovie(Movie movie)
        {
            if (movies.Contains(movie))
            {
                movie.Points -= points;
                if(movie.Categories.Contains(this))
                    movie.Categories.Remove(this);
                movies.Remove(movie);
            }
        }

        public abstract string ReturnCategoryName();

        public List<Movie> ReturnListOfMovies()
        {
            return movies;
        }

        protected void RemovePointsForEachMovie(int minusPoints)
        {
            foreach (Movie movie in movies)
                movie.Points -= minusPoints;
        }

        protected void AddPointsForEachMovie(int addPoints)
        {
            foreach (Movie movie in movies)
                movie.Points += addPoints;
        }
    }
}
