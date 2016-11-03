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

        public Rental(DateTime rentDate, DateTime returnDate)
        {
            this.rentDate = rentDate;
            this.returnDate = returnDate;
        }

        public Rental(DateTime rentDate, int daysPeriod)
        {
            this.rentDate = rentDate;
            this.returnDate = rentDate.AddDays((int)daysPeriod);
        }
    }
}
