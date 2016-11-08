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
    public partial class ClientPanel : Form
    {
        public ClientPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client_panel dodajKlienta = new Client_panel();
            dodajKlienta.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Client client in Data.Clients)
            {
                listBox1.Items.Add(client);
            }
            
            //listBox1.DataSource = Data.Clients;
        }
    }
}
