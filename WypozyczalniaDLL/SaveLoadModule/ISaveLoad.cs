using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WypozyczalniaDLL
{
    public interface ISaveLoad
    {
        bool Save(List<Client> clients, List<Movie> movies, List<Category> categories);
        bool Load(out List<Client> clients, out List<Movie> movies, out List<Category> categories);
    }
}
