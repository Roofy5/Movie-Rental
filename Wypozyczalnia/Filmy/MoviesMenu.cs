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
    public partial class MoviesMenu : Form
    {
        public MoviesMenu()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            listBox1.Items.Clear();

            foreach (Movie movie in Data.Movies)
            {
                listBox1.Items.Add(movie);
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            MovieAdd form = new MovieAdd();
            form.ShowDialog();
            RefreshList();
        }

        private void btnMovieInfo_Click(object sender, EventArgs e)
        {
            Movie movie = SelectedMovie();
            
            if (movie == null)
                return;

            MovieInformation form = new MovieInformation(movie);
            form.ShowDialog();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            Movie movie = SelectedMovie();
            if (movie == null)
                return;

            Data.Movies.Remove(movie);
            RefreshList();
        }

        private Movie SelectedMovie()
        {
            Movie movie;
            try
            {
                movie = listBox1.SelectedItem as Movie;
            }
            catch (Exception)
            {
                return null;
            }

            return movie;
        }

    }
}
