using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое натуральное число");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе натуральное число");
            int n = int.Parse(Console.ReadLine());
            int ProductOfNum = n * m;

            while (m != n)
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }

            int nod = n;
            int nok = ProductOfNum / nod;
            Console.WriteLine("НОК: " + nok);

            Console.ReadKey();
        }
    }
}
