using System;
using System.Data;
using System.Windows.Forms;

namespace ArendaKvartir
{
    // Управление пользователями (только администратор)
    public partial class Form7 : Form
    {
        bool loading;

        public Form7()
        {
            InitializeComponent();
            Theme.Apply(this, "Пользователи системы");
            cmbRole.SelectedIndex = 0;
            LoadClients();
            LoadData();
        }

        void LoadClients()
        {
            var dt = new DataTable();
            dt.Columns.Add("Код", typeof(int));
            dt.Columns.Add("ФИО", typeof(string));
            dt.Rows.Add(0, "(нет)");
            foreach (DataRow r in Db.Select("SELECT Код, ФИО FROM Клиенты ORDER BY ФИО").Rows)
                dt.Rows.Add(Convert.ToInt32(r["Код"]), Convert.ToString(r["ФИО"]));
            cmbClient.DisplayMember = "ФИО";
            cmbClient.ValueMember = "Код";
            cmbClient.DataSource = dt;
        }

        void LoadData()
        {
            int keepId = 0;
            if (dgvUsers.CurrentRow != null && dgvUsers.Columns.Contains("Код"))
                keepId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["Код"].Value);

            loading = true;
            dgvUsers.DataSource = Db.Select(
                "SELECT u.Код, u.Логин, u.Роль, c.ФИО AS Клиент, u.КодКлиента " +
                "FROM Пользователи AS u LEFT JOIN Клиенты AS c ON u.КодКлиента = c.Код ORDER BY u.Логин");
            dgvUsers.Columns["Код"].Visible = false;
            dgvUsers.Columns["КодКлиента"].Visible = false;
            loading = false;

            if (keepId != 0)
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Код"].Value) == keepId)
                    {
                        dgvUsers.CurrentCell = row.Cells["Логин"];
                        break;
                    }
                }
            }
            ShowRow();
        }

        void ShowRow()
        {
            if (loading || dgvUsers.CurrentRow == null) return;
            var r = dgvUsers.CurrentRow.Cells;
            txtLogin.Text = Convert.ToString(r["Логин"].Value);
            txtPass.Clear();
            cmbRole.Text = Convert.ToString(r["Роль"].Value);
            object c = r["КодКлиента"].Value;
            cmbClient.SelectedValue = (c == null || c == DBNull.Value) ? 0 : Convert.ToInt32(c);
        }

        int SelectedId()
        {
            return Convert.ToInt32(dgvUsers.CurrentRow.Cells["Код"].Value);
        }

        // Проверка полей; id = 0 для новой записи
        bool Check(int id, bool newUser, out int clientId)
        {
            clientId = 0;
            string login = txtLogin.Text.Trim();
            if (login.Length < 3)
            {
                Theme.Warn("Логин должен быть не короче 3 символов");
                return false;
            }
            if (Db.Count("SELECT COUNT(*) FROM Пользователи WHERE Логин = ? AND Код <> ?", login, id) > 0)
            {
                Theme.Warn("Такой логин уже есть");
                return false;
            }
            if ((newUser || txtPass.Text != "") && txtPass.Text.Length < 4)
            {
                Theme.Warn("Пароль должен быть не короче 4 символов");
                return false;
            }
            if (cmbRole.SelectedIndex < 0)
            {
                Theme.Warn("Выберите роль");
                return false;
            }
            if (cmbRole.Text == Session.Buyer)
            {
                clientId = Convert.ToInt32(cmbClient.SelectedValue);
                if (clientId == 0)
                {
                    Theme.Warn("Для роли «Покупатель» выберите клиента");
                    return false;
                }
            }
            return true;
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            ShowRow();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int clientId;
            if (!Check(0, true, out clientId)) return;
            Db.Exec("INSERT INTO Пользователи (Логин, Пароль, Роль, КодКлиента) VALUES (?, ?, ?, ?)",
                txtLogin.Text.Trim(), Db.Hash(txtPass.Text), cmbRole.Text, clientId);
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            int id = SelectedId();
            int clientId;
            if (!Check(id, false, out clientId)) return;

            // Нельзя лишить прав последнего администратора
            string oldRole = Convert.ToString(dgvUsers.CurrentRow.Cells["Роль"].Value);
            if (oldRole == Session.Admin && cmbRole.Text != Session.Admin &&
                Db.Count("SELECT COUNT(*) FROM Пользователи WHERE Роль = ?", Session.Admin) <= 1)
            {
                Theme.Warn("Нельзя изменить роль последнего администратора");
                return;
            }

            Db.Exec("UPDATE Пользователи SET Логин = ?, Роль = ?, КодКлиента = ? WHERE Код = ?",
                txtLogin.Text.Trim(), cmbRole.Text, clientId, id);
            if (txtPass.Text != "")
                Db.Exec("UPDATE Пользователи SET Пароль = ? WHERE Код = ?", Db.Hash(txtPass.Text), id);
            if (id == Session.UserId)
            {
                Session.Login = txtLogin.Text.Trim();
                Session.Role = cmbRole.Text;
                Session.ClientId = clientId;
                Theme.Info("Свои данные изменены. Роль и логин вступят в силу при следующем входе.");
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            int id = SelectedId();
            if (id == Session.UserId)
            {
                Theme.Warn("Нельзя удалить свою учётную запись");
                return;
            }
            string role = Convert.ToString(dgvUsers.CurrentRow.Cells["Роль"].Value);
            if (role == Session.Admin && Db.Count("SELECT COUNT(*) FROM Пользователи WHERE Роль = ?", Session.Admin) <= 1)
            {
                Theme.Warn("Нельзя удалить последнего администратора");
                return;
            }
            if (!Theme.Confirm("Удалить выбранного пользователя?")) return;
            Db.Exec("DELETE FROM Пользователи WHERE Код = ?", id);
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
        }
    }
}
