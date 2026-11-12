using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;
using System.Text;
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

        // SHA-256 пароля в виде hex-строки (в базе пароли открытым текстом не хранятся)
        public static string Hash(string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] b = sha.ComputeHash(Encoding.UTF8.GetBytes(password ?? ""));
                var sb = new StringBuilder();
                foreach (byte x in b) sb.Append(x.ToString("x2"));
                return sb.ToString();
            }
        }

        // Создаёт файл БД и таблицы при первом запуске; старую базу версии 1 дополняет
        public static void Init()
        {
            if (File.Exists(DbFile))
            {
                Migrate();
                return;
            }

            Type t = Type.GetTypeFromProgID("ADOX.Catalog");
            dynamic cat = Activator.CreateInstance(t);
            cat.Create(ConnStr);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(cat);

            Exec("CREATE TABLE Квартиры (Код COUNTER PRIMARY KEY, Адрес TEXT(100), Комнат INTEGER, Площадь DOUBLE, Цена DOUBLE, Статус TEXT(20))");
            Exec("CREATE TABLE Клиенты (Код COUNTER PRIMARY KEY, ФИО TEXT(100), Телефон TEXT(20))");
            Exec("CREATE TABLE Договоры (Код COUNTER PRIMARY KEY, КодКвартиры INTEGER, КодКлиента INTEGER, ДатаНачала DATETIME, Месяцев INTEGER, Скидка DOUBLE, Сумма DOUBLE)");
            Exec("CREATE TABLE Пользователи (Код COUNTER PRIMARY KEY, Логин TEXT(30), Пароль TEXT(64), Роль TEXT(20), КодКлиента INTEGER)");

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

            int ivanov = Convert.ToInt32(Scalar("SELECT MIN(Код) FROM Клиенты"));
            string insU = "INSERT INTO Пользователи (Логин, Пароль, Роль, КодКлиента) VALUES (?, ?, ?, ?)";
            Exec(insU, "admin", Hash("admin"), Session.Admin, 0);
            Exec(insU, "manager", Hash("manager"), Session.Manager, 0);
            Exec(insU, "buyer", Hash("buyer"), Session.Buyer, ivanov);
            Exec(insU, "user", Hash("user"), Session.User, 0);
        }

        // Для базы, созданной версией 1: добавляем роль, клиента, скидку и хэшируем пароли
        static void Migrate()
        {
            try { Exec("ALTER TABLE Пользователи ADD COLUMN Роль TEXT(20)"); } catch { }
            try { Exec("ALTER TABLE Пользователи ADD COLUMN КодКлиента INTEGER"); } catch { }
            try { Exec("ALTER TABLE Договоры ADD COLUMN Скидка DOUBLE"); } catch { }
            Exec("UPDATE Пользователи SET Роль = ? WHERE Роль IS NULL", Session.Admin);
            Exec("UPDATE Пользователи SET КодКлиента = 0 WHERE КодКлиента IS NULL");
            Exec("UPDATE Договоры SET Скидка = 0 WHERE Скидка IS NULL");
            DataTable users = Select("SELECT Код, Пароль FROM Пользователи");
            foreach (DataRow r in users.Rows)
            {
                string p = Convert.ToString(r["Пароль"]);
                if (p.Length != 64)
                    Exec("UPDATE Пользователи SET Пароль = ? WHERE Код = ?", Hash(p), Convert.ToInt32(r["Код"]));
            }
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

        public static int Count(string sql, params object[] p)
        {
            object o = Scalar(sql, p);
            return (o == null || o == DBNull.Value) ? 0 : Convert.ToInt32(o);
        }
    }
}
