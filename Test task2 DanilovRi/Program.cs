using System;

namespace Test_task2_DanilovRi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите слово");
            string slovo = Console.ReadLine();
            string otvet = "";

            /*Осуществляет поиск всех повторяющиxся букв
              Можно использовать другое слово для проверки например "hheellohelo" Вывод: h e l o
              Чувствительна к регистру (Вывод повторяющихся букв нижнего регистра
            или вывод повторяющихся букв верхнего регистра
             */
            for (int i = 0; i < slovo.Length; i++)
            {
                int povtor = 0;
                for (int j = i + 1; j < slovo.Length; j++) if (slovo[i] == slovo[j]) povtor++;
                if (povtor >= 1) if (otvet.Contains(slovo[i]) == false) otvet += $"{slovo[i]} ";
            }
            Console.WriteLine($"Повторяющиеся слова: {otvet}");
        }
    }
}
