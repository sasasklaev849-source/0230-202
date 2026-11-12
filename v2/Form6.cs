using System;
using System.Windows.Forms;

namespace ArendaKvartir
{
    // Самостоятельная регистрация: только роли "Покупатель" и "Пользователь"
    public partial class Form6 : Form
    {
        public string RegisteredLogin { get; private set; }

        public Form6()
        {
            InitializeComponent();
            Theme.Apply(this, "Регистрация");
            cmbType.SelectedIndex = 0;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Клиентские данные нужны только покупателю
            bool buyer = cmbType.SelectedIndex == 0;
            txtName.Enabled = buyer;
            txtPhone.Enabled = buyer;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool buyer = cmbType.SelectedIndex == 0;
            string login = txtLogin.Text.Trim();

            if (buyer && txtName.Text.Trim() == "")
            {
                Theme.Warn("Введите ФИО");
                return;
            }
            if (buyer && txtPhone.Text.Trim() == "")
            {
                Theme.Warn("Введите телефон");
                return;
            }
            if (login.Length < 3)
            {
                Theme.Warn("Логин должен быть не короче 3 символов");
                return;
            }
            if (txtPass.Text.Length < 4)
            {
                Theme.Warn("Пароль должен быть не короче 4 символов");
                return;
            }
            if (txtPass.Text != txtPass2.Text)
            {
                Theme.Warn("Пароли не совпадают");
                return;
            }
            if (Db.Count("SELECT COUNT(*) FROM Пользователи WHERE Логин = ?", login) > 0)
            {
                Theme.Warn("Такой логин уже занят");
                return;
            }

            int clientId = 0;
            string role = Session.User;
            if (buyer)
            {
                role = Session.Buyer;
                string name = txtName.Text.Trim();
                string phone = txtPhone.Text.Trim();
                Db.Exec("INSERT INTO Клиенты (ФИО, Телефон) VALUES (?, ?)", name, phone);
                clientId = Convert.ToInt32(Db.Scalar("SELECT MAX(Код) FROM Клиенты WHERE ФИО = ? AND Телефон = ?", name, phone));
            }
            Db.Exec("INSERT INTO Пользователи (Логин, Пароль, Роль, КодКлиента) VALUES (?, ?, ?, ?)",
                login, Db.Hash(txtPass.Text), role, clientId);

            RegisteredLogin = login;
            Theme.Info("Регистрация завершена. Теперь можно войти.");
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }
    }
}
