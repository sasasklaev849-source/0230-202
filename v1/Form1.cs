using System;
using System.Windows.Forms;

namespace ArendaKvartir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Db.Scalar(
                "SELECT COUNT(*) FROM Пользователи WHERE Логин = ? AND Пароль = ?",
                txtLogin.Text.Trim(), txtPass.Text));
            if (n > 0)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка входа");
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
