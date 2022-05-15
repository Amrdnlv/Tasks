using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task3_DanilovRI
{
    class BaseConverter
    {
        double celsius;
        const double raschet = 1.8; //для формулы из цельсия в фаренгейт

        //первый вариант
        public double Celsius
        {
            private get { return celsius; }
            set { celsius = value; }
        }

        public void Convert()
        {
            Console.WriteLine($"{Math.Round(celsius + 273.15, 2)} Градусов Кельвина");
            Console.WriteLine($"{Math.Round(celsius * raschet + 32, 2)} Градуса Фаренгейта");
        }


        //второй вариант
        /*
        public BaseConverter(double celsius)
        {
            this.celsius = celsius;
        }
        private double ConvertKelvina()
        {
            return Math.Round(this.celsius + 273.15, 2);
        }
        private double ConvertFarengeita()
        {
            return Math.Round(this.celsius * raschet + 32, 2);
        }
        public void ConvertShow()
        {
            Console.WriteLine($"{ConvertKelvina()} ГрадусовКельвина\n" +
                $"{ConvertFarengeita()} Градуса Фаренгейта");
        }
        */
    }
}
