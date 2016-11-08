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

        static Data() {
            Clients = new List<Client>();
            Movies = new List<Movie>();
        }
    }
}
