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
    public partial class PrintOutMenu : Form
    {
        Rental selectedRental;

        public PrintOutMenu(Rental rental)
        {
            InitializeComponent();
            selectedRental = rental;
            RefreshData();
        }

        private void RefreshData()
        {
            listPrintOutTypes.Items.Clear();

            foreach (IPrintOut type in Data.PrintOutTypes)
            {
                listPrintOutTypes.Items.Add(type);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            IPrintOut printer;
            try
            {
                printer = listPrintOutTypes.SelectedItem as IPrintOut;
            }
            catch (Exception)
            {
                return;
            }
            string output = "";

            if (printer == null)
                return;

            if(radioAll.Checked)
                output = printer.PrintOut(selectedRental);
            else if (radioPoints.Checked)
                output = printer.PrintOut(selectedRental, PrintConfiguration.POINTS_ONLY);
            else if (radioPrice.Checked)
                output = printer.PrintOut(selectedRental, PrintConfiguration.PRICE_ONLY);

            richTextBox1.Text = output;
        }
    }
}
