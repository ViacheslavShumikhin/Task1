using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S._2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дана задача: S2.9. Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве.");
            Console.WriteLine("Введите количество людей в государстве:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите площадь государства:");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = (a / b);
            Console.WriteLine($"Плотность населения равно {result} кв/км");
        }
    }
}
