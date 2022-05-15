using System;

namespace Test_Task3_DanilovRI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите градусы по фарингейту");

            BaseConverter baseConverter = new BaseConverter();
            double cel = Convert.ToDouble(Console.ReadLine());
            baseConverter.Celsius = cel;
            baseConverter.Convert();

            //вторая реализация
            /*
            BaseConverter baseConverter = new BaseConverter(32); //32-градусы
            baseConverter.ConvertShow();
            */
        }
    }
}
