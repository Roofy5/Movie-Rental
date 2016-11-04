using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class CategoryNormal : Category
    {
        private static CategoryNormal instance;
        public static CategoryNormal Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryNormal();
                return instance;
            }
        }

        private CategoryNormal()
        {
            movies = new List<Movie>();
            points = 0;
        }

        public override string ReturnCategoryName()
        {
            return "Normal";
        }

    }
}
