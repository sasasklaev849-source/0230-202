using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ArendaKvartir
{
    public static class Db
    {
        public static string DbFile = Path.Combine(Application.StartupPath, "Аренда.accdb");

        public static string ConnStr
        {
            get { return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DbFile + ";"; }
        }

        // Создаёт файл БД и таблицы при первом запуске
        public static void Init()
        {
            if (File.Exists(DbFile)) return;

            Type t = Type.GetTypeFromProgID("ADOX.Catalog");
            dynamic cat = Activator.CreateInstance(t);
            cat.Create(ConnStr);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(cat);

            Exec("CREATE TABLE Квартиры (Код COUNTER PRIMARY KEY, Адрес TEXT(100), Комнат INTEGER, Площадь DOUBLE, Цена DOUBLE, Статус TEXT(20))");
            Exec("CREATE TABLE Клиенты (Код COUNTER PRIMARY KEY, ФИО TEXT(100), Телефон TEXT(20))");
            Exec("CREATE TABLE Договоры (Код COUNTER PRIMARY KEY, КодКвартиры INTEGER, КодКлиента INTEGER, ДатаНачала DATETIME, Месяцев INTEGER, Сумма DOUBLE)");
            Exec("CREATE TABLE Пользователи (Код COUNTER PRIMARY KEY, Логин TEXT(30), Пароль TEXT(30))");

            Exec("INSERT INTO Пользователи (Логин, Пароль) VALUES (?, ?)", "admin", "admin");

            string ins = "INSERT INTO Квартиры (Адрес, Комнат, Площадь, Цена, Статус) VALUES (?, ?, ?, ?, ?)";
            Exec(ins, "ул. Пушкинская, 12, кв. 5", 1, 34.5, 15000.0, "Свободна");
            Exec(ins, "ул. Холмогорова, 20, кв. 48", 2, 52.0, 22000.0, "Свободна");
            Exec(ins, "ул. Ленина, 7, кв. 31", 3, 71.3, 30000.0, "Свободна");
            Exec(ins, "ул. Удмуртская, 101, кв. 9", 1, 29.0, 13000.0, "Свободна");
            Exec(ins, "ул. Красная, 66, кв. 14", 2, 48.8, 20000.0, "Свободна");

            string insC = "INSERT INTO Клиенты (ФИО, Телефон) VALUES (?, ?)";
            Exec(insC, "Иванов Иван Иванович", "89127000001");
            Exec(insC, "Петрова Анна Сергеевна", "89127000002");
            Exec(insC, "Смирнов Олег Андреевич", "89127000003");
        }

        public static int Exec(string sql, params object[] p)
        {
            using (var c = new OleDbConnection(ConnStr))
            using (var cmd = new OleDbCommand(sql, c))
            {
                foreach (var v in p) cmd.Parameters.AddWithValue("?", v);
                c.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static DataTable Select(string sql, params object[] p)
        {
            using (var c = new OleDbConnection(ConnStr))
            using (var cmd = new OleDbCommand(sql, c))
            {
                foreach (var v in p) cmd.Parameters.AddWithValue("?", v);
                var dt = new DataTable();
                new OleDbDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }

        public static object Scalar(string sql, params object[] p)
        {
            using (var c = new OleDbConnection(ConnStr))
            using (var cmd = new OleDbCommand(sql, c))
            {
                foreach (var v in p) cmd.Parameters.AddWithValue("?", v);
                c.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
