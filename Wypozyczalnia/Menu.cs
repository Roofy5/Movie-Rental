using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
