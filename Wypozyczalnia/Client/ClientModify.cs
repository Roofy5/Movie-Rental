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
    public partial class ClientModify : Form
    {
        Client selectedUser;

        public ClientModify(Client data)
        {
            InitializeComponent();
            selectedUser = data;
        }

        private void ClientModify_Load(object sender, EventArgs e)
        {
            txtImie.Text = selectedUser.PersonalData.Name;
            txtNazwisko.Text = selectedUser.PersonalData.Surname;
            dateTimePicker1.Value = selectedUser.PersonalData.BirthDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedUser.PersonalData.Name = txtImie.Text;
            selectedUser.PersonalData.Surname = txtNazwisko.Text;
            selectedUser.PersonalData.BirthDate = dateTimePicker1.Value;

            this.Close();
        }
    }
}
