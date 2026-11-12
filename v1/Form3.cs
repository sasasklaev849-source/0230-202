using System;
using System.Data;
using System.Windows.Forms;

namespace ArendaKvartir
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            cmbStatus.SelectedIndex = 0;
            LoadData();
        }

        void LoadData()
        {
            dgvApartments.DataSource = Db.Select("SELECT * FROM Квартиры ORDER BY Код");
            dgvApartments.Columns["Код"].Visible = false;
            dgvApartments.Columns["Цена"].HeaderText = "Цена, руб/мес";
            dgvApartments.Columns["Площадь"].HeaderText = "Площадь, м²";
        }

        void ShowRow()
        {
            if (dgvApartments.CurrentRow == null) return;
            var r = dgvApartments.CurrentRow.Cells;
            txtAddr.Text = Convert.ToString(r["Адрес"].Value);
            numRooms.Value = Convert.ToDecimal(r["Комнат"].Value);
            txtArea.Text = Convert.ToString(r["Площадь"].Value);
            txtPrice.Text = Convert.ToString(r["Цена"].Value);
            cmbStatus.Text = Convert.ToString(r["Статус"].Value);
        }

        bool ReadFields(out double area, out double price)
        {
            area = 0;
            price = 0;
            if (txtAddr.Text.Trim() == "")
            {
                MessageBox.Show("Введите адрес");
                return false;
            }
            if (!double.TryParse(txtArea.Text, out area) || area <= 0)
            {
                MessageBox.Show("Площадь должна быть положительным числом");
                return false;
            }
            if (!double.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Цена должна быть положительным числом");
                return false;
            }
            return true;
        }

        private void dgvApartments_SelectionChanged(object sender, EventArgs e)
        {
            ShowRow();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double area, price;
            if (!ReadFields(out area, out price)) return;
            Db.Exec("INSERT INTO Квартиры (Адрес, Комнат, Площадь, Цена, Статус) VALUES (?, ?, ?, ?, ?)",
                txtAddr.Text.Trim(), (int)numRooms.Value, area, price, cmbStatus.Text);
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvApartments.CurrentRow == null) return;
            double area, price;
            if (!ReadFields(out area, out price)) return;
            int id = Convert.ToInt32(dgvApartments.CurrentRow.Cells["Код"].Value);
            Db.Exec("UPDATE Квартиры SET Адрес = ?, Комнат = ?, Площадь = ?, Цена = ?, Статус = ? WHERE Код = ?",
                txtAddr.Text.Trim(), (int)numRooms.Value, area, price, cmbStatus.Text, id);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvApartments.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvApartments.CurrentRow.Cells["Код"].Value);
            int n = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Договоры WHERE КодКвартиры = ?", id));
            if (n > 0)
            {
                MessageBox.Show("Нельзя удалить квартиру, по которой есть договоры");
                return;
            }
            if (MessageBox.Show("Удалить выбранную квартиру?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            Db.Exec("DELETE FROM Квартиры WHERE Код = ?", id);
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
