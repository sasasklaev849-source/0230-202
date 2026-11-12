using System;
using System.Data;
using System.Windows.Forms;

namespace ArendaKvartir
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvClients.DataSource = Db.Select("SELECT * FROM Клиенты ORDER BY ФИО");
            dgvClients.Columns["Код"].Visible = false;
        }

        bool Check()
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Введите ФИО");
                return false;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Введите телефон");
                return false;
            }
            return true;
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
            int n = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Договоры WHERE КодКлиента = ?", id));
            if (n > 0)
            {
                MessageBox.Show("Нельзя удалить клиента, у которого есть договоры");
                return;
            }
            if (MessageBox.Show("Удалить выбранного клиента?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            Db.Exec("DELETE FROM Клиенты WHERE Код = ?", id);
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
