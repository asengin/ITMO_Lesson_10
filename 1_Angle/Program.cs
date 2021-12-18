using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Angle
{
    class Program
    {
        /*
         * Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. Реализовать класс, 
         * в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных. Класс должен 
         * содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. Создать объект на 
         * основе разработанного класса. Осуществить использование объекта в программе.
         * 
         * В методе Main происходит получение исходных данных и передача их на обработку в экземпляр класса Angle firstAngle.
         * В классе Angle созданы свойства Grad, Min, Sec с помощью которых осуществляется контроль входных параметров и доступа к ним.
         * Конструктор позволяет на этапе создания объекта установить начальные значения.
         * Отдельным методом в классе осуществляется перевод градусов в минуты, доступ к методу публичный для возможности вызова из вне.
         * Далее в методе Main выводятся свойства объекта и результат работы метода ToRadians.
         */
        static void Main(string[] args)
        {
            #region Ввод данных
            Console.Write("Введите градусы: ");
            int grad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            #endregion
            Angle firstAngle = new Angle(grad, min, sec);
            Console.WriteLine($"Угол в градусах: {firstAngle.Grad}°{firstAngle.Min}'{firstAngle.Sec}\"");
            Console.WriteLine($"Угол в радианах: {firstAngle.ToRadians():f4}");
            Console.ReadKey();
            
        }
    }
}
