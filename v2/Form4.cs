using System;
using System.Data;
using System.Windows.Forms;

namespace ArendaKvartir
{
    // Клиенты (администратор и менеджер)
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Theme.Apply(this, "Клиенты");
            LoadData();
        }

        void LoadData()
        {
            int keepId = 0;
            if (dgvClients.CurrentRow != null && dgvClients.Columns.Contains("Код"))
                keepId = Convert.ToInt32(dgvClients.CurrentRow.Cells["Код"].Value);

            string s = txtSearch.Text.Trim();
            DataTable dt = s == ""
                ? Db.Select("SELECT * FROM Клиенты ORDER BY ФИО")
                : Db.Select("SELECT * FROM Клиенты WHERE ФИО LIKE ? OR Телефон LIKE ? ORDER BY ФИО", "%" + s + "%", "%" + s + "%");
            dgvClients.DataSource = dt;
            dgvClients.Columns["Код"].Visible = false;

            if (keepId != 0)
            {
                foreach (DataGridViewRow row in dgvClients.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Код"].Value) == keepId)
                    {
                        dgvClients.CurrentCell = row.Cells["ФИО"];
                        break;
                    }
                }
            }
        }

        bool Check()
        {
            if (txtName.Text.Trim() == "")
            {
                Theme.Warn("Введите ФИО");
                return false;
            }
            if (txtPhone.Text.Trim() == "")
            {
                Theme.Warn("Введите телефон");
                return false;
            }
            return true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;
            txtName.Text = Convert.ToString(dgvClients.CurrentRow.Cells["ФИО"].Value);
            txtPhone.Text = Convert.ToString(dgvClients.CurrentRow.Cells["Телефон"].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Check()) return;
            Db.Exec("INSERT INTO Клиенты (ФИО, Телефон) VALUES (?, ?)", txtName.Text.Trim(), txtPhone.Text.Trim());
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null || !Check()) return;
            int id = Convert.ToInt32(dgvClients.CurrentRow.Cells["Код"].Value);
            Db.Exec("UPDATE Клиенты SET ФИО = ?, Телефон = ? WHERE Код = ?", txtName.Text.Trim(), txtPhone.Text.Trim(), id);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvClients.CurrentRow.Cells["Код"].Value);
            if (Db.Count("SELECT COUNT(*) FROM Договоры WHERE КодКлиента = ?", id) > 0)
            {
                Theme.Warn("Нельзя удалить клиента, у которого есть договоры");
                return;
            }
            if (Db.Count("SELECT COUNT(*) FROM Пользователи WHERE КодКлиента = ?", id) > 0)
            {
                Theme.Warn("Клиент привязан к учётной записи покупателя. Сначала измените или удалите её в разделе «Пользователи»");
                return;
            }
            if (!Theme.Confirm("Удалить выбранного клиента?")) return;
            Db.Exec("DELETE FROM Клиенты WHERE Код = ?", id);
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }
    }
}
