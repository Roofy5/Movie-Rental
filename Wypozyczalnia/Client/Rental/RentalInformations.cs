using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WypozyczalniaDLL;

namespace Wypozyczalnia
{
    public partial class RentalInformations : Form
    {
        Rental selectedRental;

        public RentalInformations(Rental rental)
        {
            InitializeComponent();
            selectedRental = rental;
            RefreshData();
        }

        private void RefreshData()
        {
            dateTimePickerRentDate.Value = selectedRental.RentDate;
            dateTimePickerReturnDate.Value = selectedRental.ReturnDate;

            listMovies.Items.Clear();
            foreach (Movie movie in selectedRental.MoviesList)
            {
                listMovies.Items.Add(movie);
            }

            txtDays.Text = (dateTimePickerReturnDate.Value - dateTimePickerRentDate.Value).Days.ToString();
            txtMovies.Text = listMovies.Items.Count.ToString();
            txtPoints.Text = selectedRental.CalculatePoints().ToString();
            txtPrice.Text = selectedRental.CalculatePrice().ToString();
            txtStrategiaPkt.Text = selectedRental.PointsStrategy.ToString();
        }
    }
}
