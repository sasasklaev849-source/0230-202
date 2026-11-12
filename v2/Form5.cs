using System;
using System.Data;
using System.Windows.Forms;

namespace ArendaKvartir
{
    // Договоры аренды: администратор и менеджер видят все и оформляют на любого клиента,
    // покупатель видит и оформляет только свои
    public partial class Form5 : Form
    {
        DataTable apts;

        public Form5()
        {
            InitializeComponent();
            Theme.Apply(this, Session.IsBuyer ? "Мои договоры аренды" : "Договоры аренды");

            if (!Session.CanManage) btnDelete.Visible = false;
            if (Session.IsBuyer) btnAdd.Text = "Арендовать";
            LoadGrid();
            LoadCombos();
        }

        void LoadGrid()
        {
            string sql =
                "SELECT d.Код, k.Адрес, c.ФИО, d.ДатаНачала, d.Месяцев, d.Скидка, d.Сумма " +
                "FROM (Договоры AS d INNER JOIN Квартиры AS k ON d.КодКвартиры = k.Код) " +
                "INNER JOIN Клиенты AS c ON d.КодКлиента = c.Код ";
            DataTable dt;
            if (Session.IsBuyer)
                dt = Db.Select(sql + "WHERE d.КодКлиента = ? ORDER BY d.Код", Session.ClientId);
            else
                dt = Db.Select(sql + "ORDER BY d.Код");

            dgvContracts.DataSource = dt;
            dgvContracts.Columns["Код"].Visible = false;
            dgvContracts.Columns["ДатаНачала"].HeaderText = "Дата начала";
            dgvContracts.Columns["ДатаНачала"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvContracts.Columns["Скидка"].HeaderText = "Скидка, %";
            dgvContracts.Columns["Сумма"].HeaderText = "Сумма, руб";
            dgvContracts.Columns["Сумма"].DefaultCellStyle.Format = "N2";
        }

        void LoadCombos()
        {
            apts = Db.Select("SELECT Код, Адрес, Цена FROM Квартиры WHERE Статус = 'Свободна' ORDER BY Адрес");
            cmbApt.DisplayMember = "Адрес";
            cmbApt.ValueMember = "Код";
            cmbApt.DataSource = apts;

            DataTable clients;
            if (Session.IsBuyer)
                clients = Db.Select("SELECT Код, ФИО FROM Клиенты WHERE Код = ?", Session.ClientId);
            else
                clients = Db.Select("SELECT Код, ФИО FROM Клиенты ORDER BY ФИО");
            cmbClient.DisplayMember = "ФИО";
            cmbClient.ValueMember = "Код";
            cmbClient.DataSource = clients;
            if (Session.IsBuyer) cmbClient.Enabled = false;

            ShowSum();
        }

        void ShowSum()
        {
            if (apts == null || cmbApt.SelectedIndex < 0 || cmbApt.SelectedIndex >= apts.Rows.Count)
            {
                lblPriceInfo.Text = "Цена: -";
                lblDiscount.Text = "Скидка: -";
                lblSum.Text = "Итого: -";
                return;
            }
            double price = Convert.ToDouble(apts.Rows[cmbApt.SelectedIndex]["Цена"]);
            int months = (int)numMonths.Value;
            lblPriceInfo.Text = "Цена: " + price.ToString("N0") + " руб/мес";
            lblDiscount.Text = "Скидка за срок: " + Calc.DiscountPercent(months) + "%";
            lblSum.Text = "Итого: " + Calc.Total(price, months).ToString("N2") + " руб";
        }

        private void Recalc_Changed(object sender, EventArgs e)
        {
            ShowSum();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbApt.SelectedIndex < 0)
            {
                Theme.Warn("Нет свободных квартир для выбора");
                return;
            }
            if (cmbClient.SelectedIndex < 0)
            {
                Theme.Warn(Session.IsBuyer
                    ? "К вашей учётной записи не привязан клиент. Обратитесь к администратору"
                    : "Выберите клиента");
                return;
            }
            int aptId = Convert.ToInt32(cmbApt.SelectedValue);
            // Квартиру мог занять другой пользователь, пока форма была открыта
            if (Db.Count("SELECT COUNT(*) FROM Квартиры WHERE Код = ? AND Статус = 'Свободна'", aptId) == 0)
            {
                Theme.Warn("Эта квартира уже сдана. Список обновлён");
                LoadCombos();
                return;
            }
            int clientId = Convert.ToInt32(cmbClient.SelectedValue);
            int months = (int)numMonths.Value;
            double price = Convert.ToDouble(apts.Rows[cmbApt.SelectedIndex]["Цена"]);
            double discount = Calc.DiscountPercent(months);
            double sum = Calc.Total(price, months);

            Db.Exec("INSERT INTO Договоры (КодКвартиры, КодКлиента, ДатаНачала, Месяцев, Скидка, Сумма) VALUES (?, ?, ?, ?, ?, ?)",
                aptId, clientId, dtpStart.Value.Date, months, discount, sum);
            Db.Exec("UPDATE Квартиры SET Статус = 'Сдана' WHERE Код = ?", aptId);
            LoadGrid();
            LoadCombos();
            Theme.Info("Договор оформлен. Сумма: " + sum.ToString("N2") + " руб");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Session.CanManage || dgvContracts.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvContracts.CurrentRow.Cells["Код"].Value);
            if (!Theme.Confirm("Удалить выбранный договор? Квартира станет свободной.")) return;
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
