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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnKlienci_Click(object sender, EventArgs e)
        {
            ClientPanel klientPanel = new ClientPanel();
            klientPanel.ShowDialog();
            //this.Hide();
        }

        private void btnFilmy_Click(object sender, EventArgs e)
        {
            MoviesMenu form = new MoviesMenu();
            form.ShowDialog();
        }

        private void btnKategorie_Click(object sender, EventArgs e)
        {
            CategoriesMenu form = new CategoriesMenu();
            form.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ISaveLoad saver = new SaveLoadToXML(saveFileDialog1.FileName);
                saver.Save(Data.Clients, Data.Movies, Data.Categories);
            }
        }
    }
}
