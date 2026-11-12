using System;
using System.Windows.Forms;

namespace ArendaKvartir
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Db.Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подготовить базу данных:\n" + ex.Message, "Ошибка");
                return;
            }
            using (var login = new Form1())
            {
                if (login.ShowDialog() != DialogResult.OK) return;
            }
            Application.Run(new Form2());
        }
    }
}
