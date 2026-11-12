using System;
using System.Data;
using System.Windows.Forms;

namespace ArendaKvartir
{
    // Форма входа
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Theme.Apply(this, "Вход в систему");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataTable dt = Db.Select(
                "SELECT Код, Логин, Роль, КодКлиента FROM Пользователи WHERE Логин = ? AND Пароль = ?",
                txtLogin.Text.Trim(), Db.Hash(txtPass.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();
                return;
            }

            DataRow r = dt.Rows[0];
            Session.UserId = Convert.ToInt32(r["Код"]);
            Session.Login = Convert.ToString(r["Логин"]);
            Session.Role = Convert.ToString(r["Роль"]);
            Session.ClientId = r["КодКлиента"] == DBNull.Value ? 0 : Convert.ToInt32(r["КодКлиента"]);
            DialogResult = DialogResult.OK;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var f = new Form6())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    txtLogin.Text = f.RegisteredLogin;
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
