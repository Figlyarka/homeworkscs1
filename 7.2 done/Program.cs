using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координату х ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату у");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(CheckingCoordinat(x, y));

        }
        static bool CheckingCoordinat(double x, double y)
        {
            if ((y >= -2) && ((x <= -3) || (x >= -1)))
            {
                return true;
            }
            return false;
        }
    }
}