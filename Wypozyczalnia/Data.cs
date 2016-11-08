using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WypozyczalniaDLL;

namespace Wypozyczalnia
{
    static class Data
    {
        public static List<Client> Clients;
        public static List<Movie> Movies;
        public static List<Category> Categories;

        static Data()
        {
            Clients = new List<Client>();
            Movies = new List<Movie>();
            Categories = new List<Category>()
            {
                CategoryChild.Instance,
                CategoryNormal.Instance,
                CategoryNew.Instance
            };

            CategoryChild.Instance.PointsPerDay = 1;
            CategoryNormal.Instance.PointsPerDay = 2;
            CategoryNew.Instance.PointsPerDay = 3;
        }
    }
}
