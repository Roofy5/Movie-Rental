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
    public partial class CategoriesMenu : Form
    {
        public CategoriesMenu()
        {
            InitializeComponent();
            RefreshCategoriesList();
        }

        private void RefreshCategoriesList()
        {
            listCategories.Items.Clear();

            foreach (Category cat in Data.Categories)
                listCategories.Items.Add(cat);
        }

        private void RefreshMoviesList()
        {
            listMovies.Items.Clear();
            Category category = SelectedCategory();

            if (category != null)
            {
                foreach (Movie movie in category.ReturnListOfMovies())
                {
                    listMovies.Items.Add(movie);
                }
            }
        }

        private void listCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMoviesList();

            Category category = SelectedCategory();

            if (category != null)
            {
                txtPoints.Text = category.PointsPerDay.ToString();
            }
        }

        private void btnChangePoints_Click(object sender, EventArgs e)
        {
            int points;
            try
            {
                points = int.Parse(txtPoints.Text);
            }
            catch (Exception)
            {
                txtPoints.Text = "Wrong value!";
                return;
            }

            Category category = SelectedCategory();
            if (category != null)
                category.PointsPerDay = points;

            RefreshCategoriesList();
            RefreshMoviesList();
        }

        private Category SelectedCategory()
        {
            Category category;
            try
            {
                category = listCategories.SelectedItem as Category;
            }
            catch (Exception)
            {
                return null;
            }

            return category;
        }
    }
}
