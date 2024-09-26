using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulyator
{
    internal class Kalkul
    {

        double number_one;
        double number_two;

        public void plus(double number_one, double number_two)
        {
            Console.WriteLine(number_one + number_two);
        }
        public void minus(double number_one, double number_two)
        {
            Console.WriteLine(number_one - number_two);
        }
        public void multiplication(double number_one, double number_two)
        {
            Console.WriteLine(number_one * number_two);
        }
        public void division(double number_one, double number_two)
        {
            if (number_two == 0)
            {
                Console.WriteLine("На 0 делить нельзя");
            }
            else
            {
                Console.WriteLine(number_one / number_two);
            }

        }

        public void rounding(double number_one, double number_two) //Округление
        {
            Console.WriteLine(Math.Round(number_one));
            Console.WriteLine(Math.Round(number_two));
        }

        public void arksin(double number_one, double number_two) //Арксинус
        {
            Console.WriteLine(Math.Atan(number_one));
        }

        public void degree(double number_one, double number_two) //Степень
        {
            Console.WriteLine(Math.Pow(number_one, number_two));
        }

        public void square(double number_one, double number_two) //Квадрат
        {
            Console.WriteLine(Math.Sqrt(number_one));
            Console.WriteLine(Math.Sqrt(number_two));
        }
        public void sin(double number_one, double number_two) //Синус
        {
            Console.WriteLine(Math.Sin(number_one));
            Console.WriteLine(Math.Sin(number_two));
        }
        public void tan(double number_one, double number_two) //Тангенс
        {
            Console.WriteLine(Math.Tan(number_one));
        }
        public void squreArea(double number_one, double number_two) //Площадь
        {
            Console.WriteLine(Math.Pow(number_one, 2));
            Console.WriteLine(Math.Pow(number_two, 2));
        }

        public void squarePerimeter(double number_one, double number_two) //Периметр
        {
            Console.WriteLine(4 * number_one);
            Console.WriteLine(4 * number_two);
        }

        public void circleDiameter(double num_one, double num_two) //Диаметр
        {
            Console.WriteLine(2 * number_one);
            Console.WriteLine(2 * number_two);
        }

        public void circleRadius(double number_one, double number_two) //Радиус
        {
            Console.WriteLine(number_one / 2);
            Console.WriteLine(number_two / 2);
        }
    }
}