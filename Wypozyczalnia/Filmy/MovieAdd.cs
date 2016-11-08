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
    public partial class MovieAdd : Form
    {
        private Movie movie;
        public MovieAdd()
        {
            InitializeComponent();
            movie = new Movie("", 0);
            RefreshList();
        }

        private void CalculatePoints()
        {
            txtPoints.Text = movie.Points.ToString();
        }

        private void RefreshList()
        {
            listCategories.Items.Clear();

            foreach (Category cat in Data.Categories)
            {
                listCategories.Items.Add(cat);
            }
        }

        private void listCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Category cat in Data.Categories)
            {
                cat.RemoveMovie(movie);
            }

            foreach (Category cat in listCategories.SelectedItems)
            {
                cat.AddMovie(movie);
            }

            CalculatePoints();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            movie.Name = txtNazwa.Text;
            try
            {
                movie.Price = decimal.Parse(txtPrice.Text);
            }
            catch (Exception)
            {
                txtPrice.Text = "Wrong value!";
                return;
            }
            Data.Movies.Add(movie);
            this.Close();
        }
    }
}
