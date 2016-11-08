using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class CategoryChild : Category
    {
        private static CategoryChild instance;
        public static CategoryChild Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryChild();
                return instance;
            } 
        }

        private CategoryChild()
        {
            movies = new List<Movie>();
            points = 0;
        }

        public override string ReturnCategoryName()
        {
            return "Child";
        }

        public override string ToString()
        {
            return "Dziecięce";
        }
    }
}
