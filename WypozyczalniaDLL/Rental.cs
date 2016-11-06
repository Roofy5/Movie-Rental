using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class Rental
    {
        private DateTime rentDate;
        private DateTime returnDate;
        private List<Movie> moviesList;

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        public DateTime RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }
        public List<Movie> MoviesList
        {
            get { return moviesList; }
        }

        /// <exception cref="ArgumentException"></exception>
        public Rental(DateTime rentDate, DateTime returnDate)
        {
            this.rentDate = rentDate;

            if (returnDate < rentDate)
                throw new ArgumentException("Return date must be greater than rent date!");

            this.returnDate = returnDate;
            this.moviesList = new List<Movie>();
        }

        public Rental(DateTime rentDate, int daysPeriod)
        {
            this.rentDate = rentDate;
            this.returnDate = rentDate.AddDays((int)daysPeriod);
            this.moviesList = new List<Movie>();
        }

        public decimal CalculatePrice()
        {
            decimal price = 0;
            foreach (Movie movie in moviesList)
            {
                // TODO
                // Pytanie jak liczyc dni - czy uwzgledniac date zwrotu jako dzien wypozyczony?
                price += movie.Price * (returnDate.Date - rentDate.Date).Days;
            }
            return price;
        }

        public int CalculatePoints()
        {
            int points = 0;
            foreach (Movie movie in moviesList)
            {
                // TODO
                // Pytanie jak liczyc dni - czy uwzgledniac date zwrotu jako dzien wypozyczony?
                points += movie.Points * (returnDate.Date - rentDate.Date).Days;
            }
            return points;
        }
    }
}
