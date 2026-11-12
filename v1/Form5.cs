using System;
using System.Data;
using System.Windows.Forms;

namespace ArendaKvartir
{
    public partial class Form5 : Form
    {
        DataTable apts;

        public Form5()
        {
            InitializeComponent();
            LoadGrid();
            LoadCombos();
        }

        // Расчёт суммы договора
        double CalcSum(double price, int months)
        {
            return price * months;
        }

        void LoadGrid()
        {
            dgvContracts.DataSource = Db.Select(
                "SELECT d.Код, k.Адрес, c.ФИО, d.ДатаНачала, d.Месяцев, d.Сумма " +
                "FROM (Договоры AS d INNER JOIN Квартиры AS k ON d.КодКвартиры = k.Код) " +
                "INNER JOIN Клиенты AS c ON d.КодКлиента = c.Код ORDER BY d.Код");
            dgvContracts.Columns["Код"].Visible = false;
            dgvContracts.Columns["ДатаНачала"].HeaderText = "Дата начала";
            dgvContracts.Columns["Сумма"].HeaderText = "Сумма, руб";
        }

        void LoadCombos()
        {
            apts = Db.Select("SELECT Код, Адрес, Цена FROM Квартиры WHERE Статус = 'Свободна' ORDER BY Адрес");
            cmbApt.DisplayMember = "Адрес";
            cmbApt.ValueMember = "Код";
            cmbApt.DataSource = apts;

            cmbClient.DisplayMember = "ФИО";
            cmbClient.ValueMember = "Код";
            cmbClient.DataSource = Db.Select("SELECT Код, ФИО FROM Клиенты ORDER BY ФИО");

            ShowSum();
        }

        void ShowSum()
        {
            if (apts == null || cmbApt.SelectedIndex < 0 || cmbApt.SelectedIndex >= apts.Rows.Count)
            {
                lblSum.Text = "Сумма: ";
                return;
            }
            double price = Convert.ToDouble(apts.Rows[cmbApt.SelectedIndex]["Цена"]);
            lblSum.Text = "Сумма: " + CalcSum(price, (int)numMonths.Value).ToString("N2") + " руб";
        }

        private void cmbApt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSum();
        }

        private void numMonths_ValueChanged(object sender, EventArgs e)
        {
            ShowSum();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbApt.SelectedIndex < 0)
            {
                MessageBox.Show("Нет свободных квартир для выбора");
                return;
            }
            if (cmbClient.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите клиента");
                return;
            }
            int aptId = Convert.ToInt32(cmbApt.SelectedValue);
            int clientId = Convert.ToInt32(cmbClient.SelectedValue);
            int months = (int)numMonths.Value;
            double price = Convert.ToDouble(apts.Rows[cmbApt.SelectedIndex]["Цена"]);
            double sum = CalcSum(price, months);

            Db.Exec("INSERT INTO Договоры (КодКвартиры, КодКлиента, ДатаНачала, Месяцев, Сумма) VALUES (?, ?, ?, ?, ?)",
                aptId, clientId, dtpStart.Value.Date, months, sum);
            Db.Exec("UPDATE Квартиры SET Статус = 'Сдана' WHERE Код = ?", aptId);
            LoadGrid();
            LoadCombos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContracts.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvContracts.CurrentRow.Cells["Код"].Value);
            if (MessageBox.Show("Удалить выбранный договор? Квартира станет свободной.", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            int aptId = Convert.ToInt32(Db.Scalar("SELECT КодКвартиры FROM Договоры WHERE Код = ?", id));
            Db.Exec("DELETE FROM Договоры WHERE Код = ?", id);
            Db.Exec("UPDATE Квартиры SET Статус = 'Свободна' WHERE Код = ?", aptId);
            LoadGrid();
            LoadCombos();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
