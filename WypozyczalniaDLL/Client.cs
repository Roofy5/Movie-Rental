using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public class Client
    {
        private PersonalData personalData;
        private int points;
        private List<Rental> rentalList;

        public List<Rental> RentalList
        {
            get { return rentalList; }
        }
        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        public PersonalData PersonalData
        {
            get { return personalData; }
        }

        public Client(PersonalData personalData)
        {
            this.personalData = personalData;
            points = 0;
            rentalList = new List<Rental>();
        }
    }
}
