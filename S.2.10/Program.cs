using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S._2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решаем задачу: S2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).");

            double a;
            double b;

            while (true)
            {
                Console.WriteLine("Введите значение коэффициента А");
                if (Double.TryParse(Console.ReadLine(), out a) && a != 0)
                    break;
                else
                    Console.WriteLine("Значение А не может быть равно нулю или не является числом. Пожалуйста, введите другое значение.");
            }

            Console.WriteLine("Введите значение коэффициента В");
            while (!Double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            double x = -b / a;
            Console.WriteLine($"X = {x}");
            Console.ReadKey();
        }
    }
}
