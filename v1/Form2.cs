using System;
using System.Windows.Forms;

namespace ArendaKvartir
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnApartments_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
