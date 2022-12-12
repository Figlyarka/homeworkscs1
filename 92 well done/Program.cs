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
            Console.WriteLine("Введите число ");
            double n = double.Parse(Console.ReadLine());
            Console.ReadKey();
            double a = 1;
            while (a <= n)
            {
                double square = Math.Pow(a, 2);
                Console.WriteLine($"квадрат числа: {a} равен: {square} ");
                a++;
            }



        }
    }
}
