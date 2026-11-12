using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ArendaKvartir
{
    // Вычислительный эксперимент: как срок аренды влияет на стоимость и скидку
    public partial class Form8 : Form
    {
        DataTable apts;
        readonly List<double> perMonth = new List<double>();
        readonly List<int> discounts = new List<int>();

        public Form8()
        {
            InitializeComponent();
            Theme.Apply(this, "Расчёт стоимости аренды");
            pnlChart.BackColor = Color.White;
            typeof(Panel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(pnlChart, true, null);

            apts = Db.Select("SELECT Код, Адрес, Цена FROM Квартиры ORDER BY Адрес");
            var list = new DataTable();
            list.Columns.Add("Код", typeof(int));
            list.Columns.Add("Название", typeof(string));
            foreach (DataRow r in apts.Rows)
                list.Rows.Add(Convert.ToInt32(r["Код"]),
                    Convert.ToString(r["Адрес"]) + " - " + Convert.ToDouble(r["Цена"]).ToString("N0") + " руб/мес");
            cmbApt.DisplayMember = "Название";
            cmbApt.ValueMember = "Код";
            cmbApt.DataSource = list;
            Recalc();
        }

        void Recalc()
        {
            perMonth.Clear();
            discounts.Clear();
            if (apts == null || cmbApt.SelectedIndex < 0 || cmbApt.SelectedIndex >= apts.Rows.Count)
            {
                dgvCalc.DataSource = null;
                lblInfo.Text = "Нет квартир для расчёта.";
                pnlChart.Invalidate();
                return;
            }

            double price = Convert.ToDouble(apts.Rows[cmbApt.SelectedIndex]["Цена"]);
            int max = (int)numMax.Value;

            var t = new DataTable();
            t.Columns.Add("Месяцев", typeof(int));
            t.Columns.Add("Скидка, %", typeof(double));
            t.Columns.Add("Без скидки, руб", typeof(double));
            t.Columns.Add("Итого, руб", typeof(double));
            t.Columns.Add("В месяц, руб", typeof(double));
            t.Columns.Add("Экономия, руб", typeof(double));

            for (int m = 1; m <= max; m++)
            {
                double full = price * m;
                double total = Calc.Total(price, m);
                t.Rows.Add(m, Calc.DiscountPercent(m), full, total, Math.Round(total / m, 2), Math.Round(full - total, 2));
                perMonth.Add(total / m);
                discounts.Add((int)Calc.DiscountPercent(m));
            }

            dgvCalc.DataSource = t;
            foreach (DataGridViewColumn c in dgvCalc.Columns)
                if (c.Name != "Месяцев" && c.Name != "Скидка, %") c.DefaultCellStyle.Format = "N2";

            double lastTotal = Calc.Total(price, max);
            lblInfo.Text = "Аренда на " + max + " мес.: " + lastTotal.ToString("N2") + " руб, скидка " +
                Calc.DiscountPercent(max) + "%, экономия " + (price * max - lastTotal).ToString("N2") + " руб.";
            pnlChart.Invalidate();
        }

        private void Recalc_Changed(object sender, EventArgs e)
        {
            if (cmbApt.SelectedIndex < 0) return;
            Recalc();
        }

        // Столбчатая диаграмма: эффективная цена за месяц; цвет показывает ступень скидки
        private void pnlChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            var rc = pnlChart.ClientRectangle;

            using (var br = new SolidBrush(Theme.Navy))
                g.DrawString("Цена за месяц при разном сроке, руб", Theme.Bold, br, 12, 10);
            if (perMonth.Count == 0) return;

            int left = 12, right = 12, top = 44, bottom = 52;
            int w = rc.Width - left - right;
            int h = rc.Height - top - bottom;
            double maxV = 0;
            foreach (double v in perMonth) if (v > maxV) maxV = v;
            if (maxV <= 0) return;

            Color[] steps = { Color.FromArgb(148, 163, 184), Color.FromArgb(45, 212, 191), Color.FromArgb(20, 150, 140), Color.FromArgb(15, 92, 87) };
            int n = perMonth.Count;
            float bw = (float)w / n;
            for (int i = 0; i < n; i++)
            {
                int d = discounts[i];
                int s = d >= 15 ? 3 : d >= 10 ? 2 : d >= 5 ? 1 : 0;
                float bh = (float)(perMonth[i] / maxV * h);
                using (var br = new SolidBrush(steps[s]))
                    g.FillRectangle(br, left + i * bw + 0.5f, top + h - bh, Math.Max(1f, bw - 1.5f), bh);
            }
            using (var pen = new Pen(Theme.Line))
                g.DrawLine(pen, left, top + h, left + w, top + h);

            // подписи осей и легенда
            using (var br = new SolidBrush(Theme.Muted))
            {
                g.DrawString("1", Theme.Base, br, left, top + h + 2);
                string last = n.ToString();
                SizeF sz = g.MeasureString(last, Theme.Base);
                g.DrawString(last + " мес.", Theme.Base, br, left + w - sz.Width - 28, top + h + 2);
                g.DrawString(maxV.ToString("N0"), Theme.Base, br, left, top - 18);
            }
            string[] names = { "0%", "5%", "10%", "15%" };
            int lx = left;
            for (int i = 0; i < 4; i++)
            {
                using (var br = new SolidBrush(steps[i]))
                    g.FillRectangle(br, lx, rc.Height - 24, 12, 12);
                using (var br = new SolidBrush(Theme.Text))
                    g.DrawString("скидка " + names[i], Theme.Base, br, lx + 15, rc.Height - 28);
                lx += 80;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
        }
    }
}
