using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class PrintToHTML : APrintOut
    {
        public override string ToString()
        {
            return "Druk do HTML";
        }

        protected override string PrintHeader(Rental rental)
        {
            StringBuilder header = new StringBuilder();
            header.Append("<hr>");
            header.Append("<b>Wypożyczalnia filmów:</b>");
            return header.ToString();
        }

        protected override string PrintPriceOnly(Rental rental, string header)
        {
            StringBuilder body = new StringBuilder(header);
            body.Append("<table border=solid>");
            body.Append("<tr><td><b>Film</b></td><td><b>Price per day</b></td><td><b>Summary price</b></td></tr>");

            foreach (Movie movie in rental.MoviesList)
            {
                body.Append(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", movie.Name, movie.Price, movie.Price * rentDays));
            }
            body.Append("</table>");
            body.Append("</br><b>Summary:</b></br>");
            body.Append("<table border=solid>");
            body.Append("<tr><td><b>No. Movies</b></td><td><b>RentDays</b></td><td>Price</b></td></tr>");
            body.Append(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", rental.MoviesList.Count, rentDays, rental.CalculatePrice()));
            body.Append("</table>");

            return body.ToString();
        }

        protected override string PrintPointsOnly(Rental rental, string header)
        {
            StringBuilder body = new StringBuilder(header);
            body.Append("<table border=solid>");
            body.Append("<tr><td><b>Film</b></td><td><b>Points per day</b></td><td><b>Summary points</b></td></tr>");

            foreach (Movie movie in rental.MoviesList)
            {
                body.Append(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", movie.Name, movie.Points, movie.Points * rentDays));
            }
            body.Append("</table>");
            body.Append("</br><b>Summary:</b></br>");
            body.Append("<table border=solid>");
            body.Append("<tr><td><b>No. Movies</b></td><td><b>RentDays</b></td><td>Points</b></td></tr>");
            body.Append(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", rental.MoviesList.Count, rentDays, rental.CalculatePoints()));
            body.Append("</table>");

            return body.ToString();
        }

        protected override string PrintAll(Rental rental, string header)
        {
            StringBuilder body = new StringBuilder(header);
            body.Append("<table border=solid>");
            body.Append("<tr><td><b>Film</b></td><td><b>Points per day</b></td><td><b>Price per day</b></td><td><b>Summary points</b></td><td><b>Summary price</b></td></tr>");

            foreach (Movie movie in rental.MoviesList)
            {
                body.Append(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>", movie.Name, movie.Points, movie.Price, movie.Points * rentDays, movie.Price * rentDays));
            }
            body.Append("</table>");
            body.Append("</br><b>Summary:</b></br>");
            body.Append("<table border=solid>");
            body.Append("<tr><td><b>No. Movies</b></td><td><b>RentDays</b></td><td><b>Points</b></td><td><b>Price</b></td></tr>");
            body.Append(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>", rental.MoviesList.Count, rentDays, rental.CalculatePoints(), rental.CalculatePrice()));
            body.Append("</table>");

            return body.ToString();
        }

        protected override string PrintFooter(string body)
        {
            StringBuilder footer = new StringBuilder(body);
            footer.Append("<hr>");
            return footer.ToString();
        }
    }
}
