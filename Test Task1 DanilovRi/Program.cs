using System;
using System.Linq;

namespace Test_Task1_DanilovRi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите количество чисел в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Неверное количество чисел в массиве\nВведите количество чисел еще раз");
                n = Convert.ToInt32(Console.ReadLine());
            }

            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                int masitem = random.Next(0, 2);
                mas[i] = masitem;
            }

            Console.WriteLine("Сгенерированый массив");

            foreach (double m in mas) Console.Write($"{m} ");

            Console.WriteLine($"\nМаксимальное значение в массиве {mas.Max()}");
            Console.WriteLine($"Минимальное значение в массиве {mas.Min()}");
            Console.WriteLine($"Средне арифметическое значение в массиве" +
                    $" {Math.Round(Convert.ToDouble(mas.Sum()) / mas.Length, 3)}");
        }
    }
}
