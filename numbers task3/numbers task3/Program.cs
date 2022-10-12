using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число с колвом десятков неравным 0");
            int num = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(num % 10 * 100 + num % 100 - num % 10 + num / 100);
            Console.ReadKey();
        }
    }
}
