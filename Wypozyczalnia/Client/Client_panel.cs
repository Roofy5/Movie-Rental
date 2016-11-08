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
    public partial class Client_panel : Form
    {
        public Client_panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonalData pers = new PersonalData(txtImie.Text, txtNazwisko.Text, dateTimePicker1.Value);
            Data.Clients.Add(new WypozyczalniaDLL.Client(pers));

            this.Close();
        }
    }
}
