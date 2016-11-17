using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class CategoryWestern : Category
    {
        private static CategoryWestern instance;
        public static CategoryWestern Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryWestern();
                return instance;
            } 
        }

        private CategoryWestern()
        {
            movies = new List<Movie>();
            points = 0;
        }

        public override string ReturnCategoryName()
        {
            return "Western";
        }

        public override string ToString()
        {
            return "Western";
        }
    }
}
