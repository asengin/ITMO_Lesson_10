using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Angle
{
    class Angle
    {
        int grad;
        int min;
        int sec;

        public int Grad
        {
            set
            {
                if (value > 360) // Как можно сократить данный блок? switch case не смог применить, потому что case требует int и не поддерживает диапазон
                    grad = value % 360;
                if (value >= 0 && value <= 360)
                    grad = value;
                if (value < 0 && value >= -360)
                    grad = 360 + value;
                if (value < -360)
                    grad = 360 + value % 360;

            }
            get { return grad; }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value < 60)
                    min = value;
                else
                {
                    min = 0;
                    Console.WriteLine($"Значение минут должно находиться в диапазоне от 0 до 60. Присвоено значение по умолчанию: {min}");
                }
            }
            get { return min; }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                    sec = value;
                else
                {
                    sec = 0;
                    Console.WriteLine($"Значение секунд должно находиться в диапазоне от 0 до 60. Присвоено значение по умолчанию: {min}");
                }
            }
            get { return sec; }
        }

        public Angle(int grad, int min, int sec) //Конструктор
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }

        public double ToRadians() //Требуется ли здесь указывать аргументы ?
        {
            double radians = (Grad + Min / 60 + Sec / 3600) * Math.PI / 180; //К чему лучше обращаться, свойствам или полям?
            return radians;
        }
    }
}
