using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArendaKvartir
{
    // Единый стиль приложения: цвета, шрифты, плоские кнопки, таблицы
    public static class Theme
    {
        public static readonly Color Navy = ColorTranslator.FromHtml("#1B2A41");
        public static readonly Color Accent = ColorTranslator.FromHtml("#0F766E");
        public static readonly Color AccentHover = ColorTranslator.FromHtml("#115E59");
        public static readonly Color Danger = ColorTranslator.FromHtml("#B91C1C");
        public static readonly Color DangerHover = ColorTranslator.FromHtml("#991B1B");
        public static readonly Color Bg = ColorTranslator.FromHtml("#F3F5F7");
        public static readonly Color Card = Color.White;
        public static readonly Color Muted = ColorTranslator.FromHtml("#6B7280");
        public static readonly Color Line = ColorTranslator.FromHtml("#D1D5DB");
        public static readonly Color RowAlt = ColorTranslator.FromHtml("#F0F7F6");
        public static readonly Color Select = ColorTranslator.FromHtml("#CCEBE7");
        public static readonly Color Ok = ColorTranslator.FromHtml("#047857");
        public static readonly Color Text = ColorTranslator.FromHtml("#111827");

        public static readonly Font Base = new Font("Segoe UI", 9.5F);
        public static readonly Font Bold = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        public static readonly Font Big = new Font("Segoe UI", 13F, FontStyle.Bold);
        public static readonly Font Title = new Font("Segoe UI", 15F, FontStyle.Bold);

        public static void Apply(Form f, string title)
        {
            f.Font = Base;
            f.BackColor = Bg;
            f.ForeColor = Text;
            Style(f.Controls);
            AddHeader(f, title);
        }

        static void AddHeader(Form f, string title)
        {
            var p = new Panel();
            p.Dock = DockStyle.Top;
            p.Height = 56;
            p.BackColor = Navy;

            var t = new Label();
            t.AutoSize = true;
            t.Text = title;
            t.Font = Title;
            t.ForeColor = Color.White;
            t.BackColor = Color.Transparent;
            t.Location = new Point(20, 12);
            p.Controls.Add(t);

            if (Session.Login != null)
            {
                var u = new Label();
                u.AutoSize = true;
                u.Text = Session.Login + "  ·  " + Session.Role;
                u.ForeColor = ColorTranslator.FromHtml("#99F6E4");
                u.BackColor = Color.Transparent;
                u.Location = new Point(Math.Max(300, f.ClientSize.Width - u.PreferredWidth - 20), 19);
                u.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                p.Controls.Add(u);
            }

            f.Controls.Add(p);
            p.SendToBack();
        }

        static void Style(Control.ControlCollection items)
        {
            foreach (Control c in items)
            {
                if (c is Button) StyleButton((Button)c);
                else if (c is DataGridView) StyleGrid((DataGridView)c);
                else if (c is TextBox) { ((TextBox)c).BorderStyle = BorderStyle.FixedSingle; }
                else if (c is Label) StyleLabel((Label)c);
                else if (c is FlowLayoutPanel) c.BackColor = Bg;
                else if (c is Panel) c.BackColor = Card;

                if (c.HasChildren && !(c is DataGridView)) Style(c.Controls);
            }
        }

        static void StyleLabel(Label l)
        {
            l.BackColor = Color.Transparent;
            string tag = l.Tag as string;
            if (tag == "muted") l.ForeColor = Muted;
            else if (tag == "big") { l.Font = Big; l.ForeColor = Accent; }
        }

        static void StyleButton(Button b)
        {
            string tag = b.Tag as string;
            string n = b.Name;
            string kind = tag;
            if (kind == null)
            {
                if (n.Contains("Delete")) kind = "danger";
                else if (n.Contains("Close") || n.Contains("Cancel") || n.Contains("Exit") ||
                         n.Contains("Logout") || n.Contains("Register")) kind = "secondary";
                else kind = "primary";
            }

            b.UseVisualStyleBackColor = false;
            b.FlatStyle = FlatStyle.Flat;
            b.Cursor = Cursors.Hand;
            b.FlatAppearance.BorderSize = 1;

            Color back, hover, fore, border;
            switch (kind)
            {
                case "danger":
                    back = Danger; hover = DangerHover; fore = Color.White; border = Danger;
                    b.Font = Bold;
                    break;
                case "secondary":
                    back = Color.White; hover = ColorTranslator.FromHtml("#E5E7EB"); fore = Text; border = Line;
                    b.Font = Base;
                    break;
                case "tile":
                    back = Color.White; hover = Select; fore = Navy; border = Line;
                    b.Font = Big;
                    b.TextAlign = ContentAlignment.MiddleLeft;
                    b.Padding = new Padding(18, 0, 0, 0);
                    break;
                default:
                    back = Accent; hover = AccentHover; fore = Color.White; border = Accent;
                    b.Font = Bold;
                    break;
            }
            b.BackColor = back;
            b.ForeColor = fore;
            b.FlatAppearance.BorderColor = border;
            b.FlatAppearance.MouseOverBackColor = hover;
            b.FlatAppearance.MouseDownBackColor = hover;
        }

        public static void StyleGrid(DataGridView g)
        {
            g.EnableHeadersVisualStyles = false;
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.GridColor = Line;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToResizeRows = false;
            g.ReadOnly = true;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 36;
            g.RowTemplate.Height = 30;

            g.ColumnHeadersDefaultCellStyle.BackColor = Navy;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Font = Bold;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Navy;
            g.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);

            g.DefaultCellStyle.BackColor = Color.White;
            g.DefaultCellStyle.ForeColor = Text;
            g.DefaultCellStyle.SelectionBackColor = Select;
            g.DefaultCellStyle.SelectionForeColor = Navy;
            g.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            g.AlternatingRowsDefaultCellStyle.BackColor = RowAlt;
        }

        public static void Info(string text)
        {
            MessageBox.Show(text, "Аренда квартир", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warn(string text)
        {
            MessageBox.Show(text, "Проверьте данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Confirm(string text)
        {
            return MessageBox.Show(text, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
