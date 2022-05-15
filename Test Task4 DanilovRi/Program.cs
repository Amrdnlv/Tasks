using System;

namespace Test_Task4_DanilovRi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");

            Console.WriteLine("Ввведите hours");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ввведите minutes");
            int minute = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("-----------------Ответ---------------");
            Console.WriteLine($"{degreez(hour, minute)} градосов / градуса");
        }
        public static double degreez(int hour, int minute)
        {
            double deg = Math.Round(Math.Abs((hour + (Convert.ToDouble(minute) / 60)) * 30 - minute * 6), 2);
            if (deg > 180) deg = 360 - deg;
            return deg;
        }
        /* Формула: (час+(минуты /60)) x 30 -минуты x 6 */
    }
}
