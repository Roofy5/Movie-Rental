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
            RefreshClientList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client_panel dodajKlienta = new Client_panel();
            dodajKlienta.ShowDialog();
            RefreshClientList();
        }

        private void btnUsunKlienta_Click(object sender, EventArgs e)
        {
            Client client = listBox1.SelectedItem as Client;
            if (client != null)
                Data.Clients.Remove(client);

            RefreshClientList();
        }

        private void btnModifyClient_Click(object sender, EventArgs e)
        {
            Client client = listBox1.SelectedItem as Client;
            if (client != null)
            {
                ClientModify form = new ClientModify(client);
                form.ShowDialog();
            }

            RefreshClientList();
        }

        private void RefreshClientList()
        {
            listBox1.Items.Clear();
            foreach (Client client in Data.Clients)
            {
                listBox1.Items.Add(client);
            }
        }

        private void btnClientInfo_Click(object sender, EventArgs e)
        {
            Client client = listBox1.SelectedItem as Client;
            if (client != null)
            {
                ClientInformation form = new ClientInformation(client);
                form.ShowDialog();
            }
        }
    }
}
