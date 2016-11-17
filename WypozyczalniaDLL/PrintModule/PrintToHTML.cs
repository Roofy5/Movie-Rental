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
            header.Append("</br>");
            header.Append("<b>Wypożyczalnia filmów:</b></br>");
            return header.ToString();
        }

        protected override string PrintPriceOnly(Rental rental, string header)
        {
            StringBuilder body = new StringBuilder(header);
            body.Append("<b>Film\tPrice per day\tSummary price</b></br>");

            foreach (Movie movie in rental.MoviesList)
            {
                body.Append(String.Format("{0}\t\t{1}\t\t{2}</br>", movie.Name, movie.Price, movie.Price * rentDays));
            }
            body.Append("</br><b>Summary:</b></br>");
            body.Append("<b>No. Movies\tRentDays\tPrice</b></br>");
            body.Append(String.Format("{0}\t\t{1}\t\t{2}</br>", rental.MoviesList.Count, rentDays, rental.CalculatePrice()));

            return body.ToString();
        }

        protected override string PrintPointsOnly(Rental rental, string header)
        {
            StringBuilder body = new StringBuilder(header);
            body.Append("<b>Film\tPoints per day\tSummary points</b></br>");

            foreach (Movie movie in rental.MoviesList)
            {
                body.Append(String.Format("{0}\t\t{1}\t\t{2}</br>", movie.Name, movie.Points, movie.Points * rentDays));
            }
            body.Append("</br><b>Summary:</b></br>");
            body.Append("<b>No. Movies\tRentDays\tPoints</b></br>");
            body.Append(String.Format("{0}\t\t{1}\t\t{2}</br>", rental.MoviesList.Count, rentDays, rental.CalculatePoints()));

            return body.ToString();
        }

        protected override string PrintAll(Rental rental, string header)
        {
            StringBuilder body = new StringBuilder(header);
            body.Append("<b>Film\tPoints per day\tPrice per day\tSummary points\tSummary price</b></br>");

            foreach (Movie movie in rental.MoviesList)
            {
                body.Append(String.Format("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}</br>", movie.Name, movie.Points, movie.Price, movie.Points * rentDays, movie.Price * rentDays));
            }
            body.Append("</br><b>Summary:</b></br>");
            body.Append("<b>No. Movies\tRentDays\tPoints\tPrice</b></br>");
            body.Append(String.Format("{0}\t\t{1}\t\t{2}\t\t{3}</br>", rental.MoviesList.Count, rentDays, rental.CalculatePoints(), rental.CalculatePrice()));

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
