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
    public partial class MovieInformation : Form
    {
        Movie selectedMovie;

        public MovieInformation(Movie movie)
        {
            InitializeComponent();
            selectedMovie = movie;
            RefreshData();
        }

        private void RefreshData()
        {
            txtNazwa.Text = selectedMovie.Name;
            txtPrice.Text = selectedMovie.Price.ToString();
            txtPoints.Text = selectedMovie.Points.ToString();

            listCategories.Items.Clear();
            foreach (Category cat in Data.Categories)
                listCategories.Items.Add(cat);
        }
    }
}
