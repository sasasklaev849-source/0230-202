using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ArendaKvartir
{
    // Квартиры: администратор и менеджер редактируют, остальные только смотрят
    public partial class Form3 : Form
    {
        bool loading;

        public Form3()
        {
            InitializeComponent();
            Theme.Apply(this, Session.CanManage ? "Квартиры" : "Каталог квартир");
            cmbRooms.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

            if (!Session.CanManage)
            {
                // Только просмотр: убираем панель редактирования, таблица занимает её место
                pnlEdit.Visible = false;
                dgvApartments.Height += pnlEdit.Height + 10;
                chkFree.Checked = Session.IsBuyer; // покупателю по умолчанию показываем свободные
            }
            LoadData();
        }

        void LoadData()
        {
            int keepId = 0;
            if (dgvApartments.CurrentRow != null && dgvApartments.Columns.Contains("Код"))
                keepId = Convert.ToInt32(dgvApartments.CurrentRow.Cells["Код"].Value);

            string sql = "SELECT * FROM Квартиры WHERE 1 = 1";
            var p = new List<object>();
            string s = txtSearch.Text.Trim();
            if (s != "")
            {
                sql += " AND Адрес LIKE ?";
                p.Add("%" + s + "%");
            }
            int ri = cmbRooms.SelectedIndex;
            if (ri >= 1 && ri <= 3)
            {
                sql += " AND Комнат = ?";
                p.Add(ri);
            }
            else if (ri == 4)
            {
                sql += " AND Комнат >= ?";
                p.Add(4);
            }
            if (chkFree.Checked) sql += " AND Статус = 'Свободна'";
            sql += " ORDER BY Код";

            loading = true;
            DataTable dt = Db.Select(sql, p.ToArray());
            dgvApartments.DataSource = dt;
            dgvApartments.Columns["Код"].Visible = false;
            dgvApartments.Columns["Цена"].HeaderText = "Цена, руб/мес";
            dgvApartments.Columns["Цена"].DefaultCellStyle.Format = "N0";
            dgvApartments.Columns["Площадь"].HeaderText = "Площадь, м²";
            loading = false;

            if (keepId != 0)
            {
                foreach (DataGridViewRow row in dgvApartments.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Код"].Value) == keepId)
                    {
                        dgvApartments.CurrentCell = row.Cells["Адрес"];
                        break;
                    }
                }
            }
            ShowRow();
            lblCount.Text = "Найдено квартир: " + dt.Rows.Count;
        }

        void ShowRow()
        {
            if (loading || dgvApartments.CurrentRow == null) return;
            var r = dgvApartments.CurrentRow.Cells;
            txtAddr.Text = Convert.ToString(r["Адрес"].Value);
            numRooms.Value = Math.Max(numRooms.Minimum, Math.Min(numRooms.Maximum, Convert.ToDecimal(r["Комнат"].Value)));
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
                Theme.Warn("Введите адрес");
                return false;
            }
            if (!Calc.TryParse(txtArea.Text, out area) || area <= 0)
            {
                Theme.Warn("Площадь должна быть положительным числом");
                return false;
            }
            if (!Calc.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                Theme.Warn("Цена должна быть положительным числом");
                return false;
            }
            return true;
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            if (cmbRooms.SelectedIndex < 0) return; // форма ещё создаётся
            LoadData();
        }

        private void dgvApartments_SelectionChanged(object sender, EventArgs e)
        {
            ShowRow();
        }

        // Статус цветом: свободна - зелёный, сдана - красный
        private void dgvApartments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvApartments.Columns[e.ColumnIndex].Name != "Статус") return;
            string v = Convert.ToString(e.Value);
            e.CellStyle.ForeColor = v == "Свободна" ? Theme.Ok : Theme.Danger;
            e.CellStyle.Font = Theme.Bold;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Session.CanManage) return;
            double area, price;
            if (!ReadFields(out area, out price)) return;
            Db.Exec("INSERT INTO Квартиры (Адрес, Комнат, Площадь, Цена, Статус) VALUES (?, ?, ?, ?, ?)",
                txtAddr.Text.Trim(), (int)numRooms.Value, area, price, cmbStatus.Text);
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!Session.CanManage || dgvApartments.CurrentRow == null) return;
            double area, price;
            if (!ReadFields(out area, out price)) return;
            int id = Convert.ToInt32(dgvApartments.CurrentRow.Cells["Код"].Value);
            Db.Exec("UPDATE Квартиры SET Адрес = ?, Комнат = ?, Площадь = ?, Цена = ?, Статус = ? WHERE Код = ?",
                txtAddr.Text.Trim(), (int)numRooms.Value, area, price, cmbStatus.Text, id);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Session.CanManage || dgvApartments.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvApartments.CurrentRow.Cells["Код"].Value);
            if (Db.Count("SELECT COUNT(*) FROM Договоры WHERE КодКвартиры = ?", id) > 0)
            {
                Theme.Warn("Нельзя удалить квартиру, по которой есть договоры");
                return;
            }
            if (!Theme.Confirm("Удалить выбранную квартиру?")) return;
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
