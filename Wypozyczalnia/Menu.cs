using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnInformacje_Click(object sender, EventArgs e)
        {
            Informacje form = new Informacje();
            form.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ISaveLoad saver = new SaveLoadToXML(saveFileDialog1.FileName);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(saveFileDialog1.FileName);
                switch (extension)
                {
                    case ".xml":
                        saver = new SaveLoadToXML(saveFileDialog1.FileName);
                        break;
                }

                
                if (saver.Save(Data.Clients, Data.Movies, Data.Categories))
                    MessageBox.Show("Zapisano!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Błąd przy zapisywaniu!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ISaveLoad loader = new SaveLoadToXML(openFileDialog1.FileName);

                string extension = Path.GetExtension(openFileDialog1.FileName);
                switch (extension)
                {
                    case ".xml":
                        loader = new SaveLoadToXML(openFileDialog1.FileName);
                        break;
                }

                try
                {
                    if(loader.Load(out Data.Clients, out Data.Movies, out Data.Categories))
                        MessageBox.Show("Wczytano!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Błąd przy wczytywaniu!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
}
