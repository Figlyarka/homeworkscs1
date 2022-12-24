using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(Func(x));
            Console.ReadKey();
        }
        static double Func(double x)
        {
            if (x > 1)
                return Math.Log(x);
            else if (x <= 0)
                return 0;
            else
                return -Math.Log(x);


        }
    }
}