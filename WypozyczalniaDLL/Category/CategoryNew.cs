using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class CategoryNew : Category
    {
        private static CategoryNew instance;
        public static CategoryNew Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryNew();
                return instance;
            }
        }

        private CategoryNew()
        {
            movies = new List<Movie>();
            points = 0;
        }

        public override string ReturnCategoryName()
        {
            return "New";
        }

        public override string ToString()
        {
            return "Nowe";
        }
    }
}
