using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastS2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Мы решаем следующую задачу: S2.8. Известны объем и масса тела. Определить плотность материала этого тела.");
            Console.WriteLine("Введите массу тела");
            double mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введете объем тела");
            double v = Convert.ToDouble(Console.ReadLine());

            double result = (mass / v);
            Console.WriteLine($"Плотность тела с массой {mass} и объемом {v} = {result}");
        }
    }
}
