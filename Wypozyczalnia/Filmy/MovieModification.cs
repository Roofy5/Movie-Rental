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
    public partial class MovieModification : Form
    {
        Movie selectedMovie;
        Movie newMovie;
        bool firstLoad = true;

        public MovieModification(ref Movie movie)
        {
            InitializeComponent();
            selectedMovie = movie;
            ShallowCopyOfMovie();
            RefreshData();
        }

        private void ShallowCopyOfMovie()
        {
            newMovie = new Movie(selectedMovie.Name, selectedMovie.Price);
            newMovie.Points = selectedMovie.Points;
            foreach (Category cat in selectedMovie.Categories)
                newMovie.Categories.Add(cat);
        }

        private void RefreshData()
        {
            txtNazwa.Text = newMovie.Name;
            txtPrice.Text = newMovie.Price.ToString();
            txtPoints.Text = newMovie.Points.ToString();
            listCategories.Items.Clear();
            foreach (Category cat in Data.Categories)
                listCategories.Items.Add(cat);
            foreach (Category cat in newMovie.Categories)
                listCategories.SetSelected(listCategories.Items.IndexOf(cat), true);
            firstLoad = !firstLoad;
        }

        private void listCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad)
                return;

            newMovie.Categories.Clear();
            newMovie.Points = 0;

            foreach (Category cat in listCategories.SelectedItems)
            {
                newMovie.Points += cat.PointsPerDay;
                newMovie.Categories.Add(cat);
            }

            txtPoints.Text = newMovie.Points.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                selectedMovie.Price = decimal.Parse(txtPrice.Text);
            }
            catch (Exception)
            {
                txtPrice.Text = "Wrong value!";
                return;
            }

            foreach (Category cat in Data.Categories)
                cat.ReturnListOfMovies().Remove(selectedMovie);

            selectedMovie.Name = txtNazwa.Text;
            selectedMovie.Points = 0;
            selectedMovie.Categories.Clear();

            foreach (Category cat in newMovie.Categories)
                cat.AddMovie(selectedMovie);

            this.Close();
        }
    }
}
