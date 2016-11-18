using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class PointsOneDayStrategy : PointsCalculatingStrategy
    {
        public override int CalcualtePoints(Rental rental)
        {
            int points = 0;
            int difference = (rental.ReturnDate - rental.RentDate).Days;
            difference = difference == 0 ? difference : difference - 1;

            foreach (Movie movie in rental.MoviesList)
            {
                int moviePoints = 5 + difference;
                if (movie.Categories.Contains(CategoryNew.Instance))
                    moviePoints *= 2;
                points += moviePoints;
            }

            return points;
        }

        public override string GetNameOfStrategy()
        {
            return "1d5p";
        }

        public override string ToString()
        {
            return "1 dzień 5pkt";
        }
    }
}
