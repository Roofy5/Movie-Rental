using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public enum PrintConfiguration
    { ALL, POINTS_ONLY, PRICE_ONLY }

    public abstract class APrintOut
    {
        protected int rentDays;
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

        protected abstract string PrintHeader(Rental rental);
        protected abstract string PrintPriceOnly(Rental rental, string header);
        protected abstract string PrintPointsOnly(Rental rental, string header);
        protected abstract string PrintAll(Rental rental, string header);
        protected abstract string PrintFooter(string body);
    }
}
