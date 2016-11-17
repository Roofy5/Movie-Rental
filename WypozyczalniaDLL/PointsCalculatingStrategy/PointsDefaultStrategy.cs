using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class PointsDefaultStrategy : PointsCalculatingStrategy
    {
        public override int CalcualtePoints(Rental rental)
        {
            int points = 0;
            foreach (Movie movie in rental.MoviesList)
            {
                // TODO
                // Pytanie jak liczyc dni - czy uwzgledniac date zwrotu jako dzien wypozyczony?
                points += movie.Points * (rental.RentDate.Date - rental.RentDate.Date).Days;
            }

            return points;
        }
    }
}
