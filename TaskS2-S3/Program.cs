using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskS2_S3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сейчас мы решаем задачу  S2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.");
            Console.WriteLine("Пожалуйста введите x1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите x2 ");
            int b = Convert.ToInt32(Console.ReadLine());

            double result = 2 * Math.Sqrt(a * b);
            Console.WriteLine($"Среднее геометрическое числа x1 - {a} и x2 - {b} равняется = {result}");

            Console.WriteLine($"Среднее арифметическое  числа x1 - {a} и x2 - {b} равняется = {(a+b)/2}");
        }
    }
}
