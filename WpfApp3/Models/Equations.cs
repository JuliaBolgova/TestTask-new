using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EquationProgram
{
    public class Equations : INotifyPropertyChanged
    {
        /// <summary>
        /// Значение числа Х
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Значение числа Y
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Значение числа A
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Значение числа B
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Значение числа C
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Конструктор Функция F(x,y)
        /// </summary>
        /// <param name="x">Значение числа x</param>
        /// <param name="y">Значение числа y</param>
        /// <param name="a">Значение числа a</param>
        /// <param name="b">Значение числа b</param>
        /// <param name="c">Значение числа c</param>
        public Equations(double x, double y, double a, double b, double c)
        {
            X = x;
            Y = y;
            A = a;
            B = b;
            C = c;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
            
        /// <summary>
        /// Вычисление по формуле
        /// </summary>
        /// <param name="ConstX">Степень числа x</param>
        /// <param name="ConstY">Степень числа y</param>
        /// <returns></returns>
        public double FunctionXY(double ConstX, double ConstY)
        {
            double fXY = A * X * ConstX + B * Math.Pow(Y, ConstY) + C;

            return fXY;
        }
    }
}
