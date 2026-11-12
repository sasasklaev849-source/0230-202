using System;
using System.Windows.Forms;

namespace ArendaKvartir
{
    // Главное меню: набор кнопок зависит от роли
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Theme.Apply(this, "Аренда квартир");

            lblUser.Text = "Здравствуйте, " + Session.Login + "!  Роль: " + Session.Role;
            lblUser.Font = Theme.Bold;
            lblInfo.Text = Session.Describe();

            btnApartments.Text = Session.CanManage ? "Квартиры" : "Каталог квартир";
            btnClients.Visible = Session.CanManage;
            btnContracts.Visible = Session.CanManage || Session.IsBuyer;
            btnContracts.Text = Session.IsBuyer ? "Мои договоры" : "Договоры аренды";
            btnUsers.Visible = Session.IsAdmin;
        }

        private void btnApartments_Click(object sender, EventArgs e)
        {
            using (var f = new Form3()) f.ShowDialog(this);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            if (!Session.CanManage) return;
            using (var f = new Form4()) f.ShowDialog(this);
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            if (!(Session.CanManage || Session.IsBuyer)) return;
            using (var f = new Form5()) f.ShowDialog(this);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            using (var f = new Form8()) f.ShowDialog(this);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!Session.IsAdmin) return;
            using (var f = new Form7()) f.ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
