using System;
using System.Globalization;

namespace ArendaKvartir
{
    // Вычислительный эксперимент: стоимость аренды со скидкой за срок
    public static class Calc
    {
        // Скидка в процентах в зависимости от срока аренды
        public static double DiscountPercent(int months)
        {
            if (months >= 24) return 15;
            if (months >= 12) return 10;
            if (months >= 6) return 5;
            return 0;
        }

        public static double Total(double price, int months)
        {
            return Math.Round(price * months * (1 - DiscountPercent(months) / 100.0), 2);
        }

        // Разбор числа: принимает и "34.5", и "34,5" независимо от региональных настроек
        public static bool TryParse(string s, out double value)
        {
            s = (s ?? "").Trim().Replace(',', '.');
            return double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
        }
    }
}
