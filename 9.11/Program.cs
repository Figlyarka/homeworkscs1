using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число меньше 500 ");
            double a = double.Parse(Console.ReadLine());
            Console.ReadKey();
            while (a < 500)
            {
                double cube = Math.Pow(a, 3);
                Console.WriteLine($"куб числа: {a} равен: {cube} ");
                a++;
            }



        }
    }
}
