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
        private PointsCalculatingStrategy pointsStrategy;

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
        public PointsCalculatingStrategy PointsStrategy
        {
            get { return pointsStrategy; }
            set { pointsStrategy = value; }
        }

        /// <exception cref="ArgumentException"></exception>
        public Rental(DateTime rentDate, DateTime returnDate, PointsCalculatingStrategy strategy = null)
        {
            this.rentDate = rentDate;

            if (returnDate < rentDate)
                throw new ArgumentException("Return date must be greater than rent date!");

            this.returnDate = returnDate;
            this.moviesList = new List<Movie>();

            //pointsStrategy = strategy == null ? new PointsDefaultStrategy() : strategy;
            pointsStrategy = strategy ?? new PointsDefaultStrategy();
        }

        public Rental(DateTime rentDate, int daysPeriod, PointsCalculatingStrategy strategy = null)
        {
            this.rentDate = rentDate;
            this.returnDate = rentDate.AddDays((int)daysPeriod);
            this.moviesList = new List<Movie>();

            //pointsStrategy = strategy == null ? new PointsDefaultStrategy() : strategy;
            pointsStrategy = strategy ?? new PointsDefaultStrategy();
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
            return pointsStrategy.CalcualtePoints(this);
        }
    }
}
