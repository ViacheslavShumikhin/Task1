using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S._2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача: S2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.");

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
                Console.WriteLine("Введите катет стороны В");
                if (Double.TryParse(Console.ReadLine(), out b) && b != 0)
                    break;
                else
                    Console.WriteLine("Значение В не может быть равно нулю или не является числом. Пожалуйста, введите другое значение.");
            }

            double x = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) ;
            Console.WriteLine($"Гипотенуза = {x}");
            Console.ReadKey();
        }
    }
}
