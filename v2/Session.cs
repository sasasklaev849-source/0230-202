namespace ArendaKvartir
{
    // Текущий вошедший пользователь и его права
    public static class Session
    {
        public const string Admin = "Администратор";
        public const string Manager = "Менеджер";
        public const string Buyer = "Покупатель";
        public const string User = "Пользователь";

        public static readonly string[] Roles = { Admin, Manager, Buyer, User };

        public static int UserId;
        public static string Login;
        public static string Role;
        public static int ClientId; // 0 - нет привязанного клиента

        public static bool IsAdmin { get { return Role == Admin; } }
        public static bool IsBuyer { get { return Role == Buyer; } }
        // Администратор и менеджер управляют квартирами, клиентами и договорами
        public static bool CanManage { get { return Role == Admin || Role == Manager; } }

        public static void Clear()
        {
            UserId = 0;
            Login = null;
            Role = null;
            ClientId = 0;
        }

        public static string Describe()
        {
            switch (Role)
            {
                case Admin: return "Полный доступ: квартиры, клиенты, договоры, пользователи.";
                case Manager: return "Управление квартирами, клиентами и договорами аренды.";
                case Buyer: return "Просмотр свободных квартир, расчёт стоимости и оформление своих договоров.";
                default: return "Просмотр каталога квартир и расчёт стоимости аренды.";
            }
        }
    }
}
