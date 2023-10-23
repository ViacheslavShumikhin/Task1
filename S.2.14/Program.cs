using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S._2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача S2.14. Даны основания и высота равнобедренной трапеции. Найти ее периметр.");

            double a;
            double b;
            double c;

            while (true)
            {
                Console.WriteLine("Введите число основания А");
                if (Double.TryParse(Console.ReadLine(), out a) && a != 0)
                break;
                else
                    Console.WriteLine("Значение А не может быть равно нулю или не является числом. Пожалуйста, введите другое значение.");
            }

            while (true)
            {
                Console.WriteLine("Введите число основания B");
                if (Double.TryParse(Console.ReadLine(), out b) && b != 0 && b < a)
                    break;
                else
                    Console.WriteLine("Значение B не может быть равно нулю или не является числом. Пожалуйста, введите другое значение.");
            }

            while (true)
            {
                Console.WriteLine("Введите число Высоты С");
                if (Double.TryParse(Console.ReadLine(), out c) && c != 0)
                    break;
                else
                    Console.WriteLine("Значение C не может быть равно нулю или не является числом. Пожалуйста, введите другое значение.");
            }

            Console.WriteLine($"Периметр трапеции равен {a + b + c + c}");

        }
    }
}
