using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S._2._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача S2.13. Даны катеты прямоугольного треугольника. Найти его периметр.");
            double a;
            double b;

            while (true)
            {
                Console.WriteLine("Введите катет стороны А");
                if (Double.TryParse(Console.ReadLine(), out a) && a != 0)
                    break;
                else
                    Console.WriteLine("Значение А не может быть равно нулю или не является числом. Пожалуйста, введите другое значение.");
            }

            while (true)
            {
                Console.WriteLine("Введите катет стороны B");
                if (Double.TryParse(Console.ReadLine(), out b) && b != 0)
                    break;
                else
                    Console.WriteLine("Значение А не может быть равно нулю или не является числом. Пожалуйста, введите другое значение.");
            }



            // Расчет гипотенузы и периметра
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double perimeter = a + b + c;

            Console.WriteLine($"Периметр треугольника составляет {perimeter}");
        }
    }
}
