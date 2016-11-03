using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public interface ICategory
    {
        int PointsPerDay { get; set; }

        void AddMovie(Movie movie);
        void RemoveMovie(Movie movie);
        string ReturnCategory(Movie movie);
        List<Movie> ReturnListOfMovies();

    }
}
