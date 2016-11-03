using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class Movie
    {
        private string name;
        private int points;
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { if (value < 0) throw new ArgumentException("Price must be greater than zero!"); else price = value; }
        }
        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Movie(string name, decimal price)
        {
            this.name = name;
            this.Price = price;
            this.points = 0;
        }
    }
}
