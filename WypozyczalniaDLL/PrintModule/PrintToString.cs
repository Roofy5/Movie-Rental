using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class PrintToString : IPrintOut
    {
        private int rentDays;


        public string PrintOut(Rental rental, PrintConfiguration configuration = PrintConfiguration.ALL)
        {
            rentDays = (rental.ReturnDate - rental.RentDate).Days;
            string header = PrintHeader(rental);
            string body = "";
            switch (configuration)
            {
                case PrintConfiguration.POINTS_ONLY:
                    body = PrintPointsOnly(rental, header);
                    break;
                case PrintConfiguration.PRICE_ONLY:
                    body = PrintPriceOnly(rental, header);
                    break;
                default:
                    body = PrintAll(rental, header);
                    break;
            }

            return PrintFooter(body);                
        }

        private string PrintHeader(Rental rental)
        {
            StringBuilder header = new StringBuilder();
            header.Append('-', 10);
            header.Append('\n');
            header.Append("Wypożyczalnia filmów:\n");
            return header.ToString();
        }

        private string PrintPriceOnly(Rental rental, string header)
        {
            StringBuilder body = new StringBuilder(header);
            body.Append("Film\tPrice per day\tSummary price\n");

            foreach (Movie movie in rental.MoviesList)
            {
                body.Append(String.Format("{0}\t\t{1}\t\t{2}\n", movie.Name, movie.Price, movie.Price*rentDays));
            }
            body.Append("\nSummary:\n");
            body.Append("No. Movies\tRentDays\tPrice\n");
            body.Append(String.Format("{0}\t\t{1}\t\t{2}\n", rental.MoviesList.Count, rentDays, rental.CalculatePrice()));

            return body.ToString();
        }

        private string PrintPointsOnly(Rental rental, string header)
        {
            StringBuilder body = new StringBuilder(header);
            body.Append("Film\tPoints per day\tSummary points\n");

            foreach (Movie movie in rental.MoviesList)
            {
                body.Append(String.Format("{0}\t\t{1}\t\t{2}\n", movie.Name, movie.Points, movie.Points * rentDays));
            }
            body.Append("\nSummary:\n");
            body.Append("No. Movies\tRentDays\tPoints\n");
            body.Append(String.Format("{0}\t\t{1}\t\t{2}\n", rental.MoviesList.Count, rentDays, rental.CalculatePoints()));

            return body.ToString();
        }

        private string PrintAll(Rental rental, string header)
        {
            StringBuilder body = new StringBuilder(header);
            body.Append("Film\tPoints per day\tPrice per day\tSummary points\tSummary price\n");

            foreach (Movie movie in rental.MoviesList)
            {
                body.Append(String.Format("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\n", movie.Name, movie.Points, movie.Price, movie.Points * rentDays, movie.Price * rentDays));
            }
            body.Append("\nSummary:\n");
            body.Append("No. Movies\tRentDays\tPoints\tPrice\n");
            body.Append(String.Format("{0}\t\t{1}\t\t{2}\t\t{3}\n", rental.MoviesList.Count, rentDays, rental.CalculatePoints(), rental.CalculatePrice()));

            return body.ToString();
        }

        private string PrintFooter(string body)
        {
            StringBuilder footer = new StringBuilder(body);
            footer.Append('-', 10);
            return footer.ToString();
        }

    }
}