using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S._2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решите задачу S2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.");

            double a;
            double b;

            while (true)
            {
                Console.WriteLine("Введите радиус внешнего кольца");
                if (Double.TryParse(Console.ReadLine(), out a) && a > 0)
                    break;
                else
                    Console.WriteLine("Значение радиуса внешнего кольца должно быть больше 0. Пожалуйста, введите другое значение.");
            }

            while (true)
            {
                Console.WriteLine("Введите радиус внутреннего кольца");
                if (Double.TryParse(Console.ReadLine(), out b) && b >= 0 && b < a)
                    break;
                else if (b >= a)
                    Console.WriteLine("Внутренний круг не может быть больше или равен внешнему, пожалуйста, введите другое значение.");
                else
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите другое значение.");
            }

            Console.WriteLine($"Площадь кольца составляет {Math.PI * (Math.Pow(a, 2) - Math.Pow(b, 2))}");

            Console.ReadKey();
        }

    }
}
