﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Calc(2, -2, 3) + Calc(3, -3, 5) + Calc(5, -5, 7);
            Console.WriteLine(x);
            Console.ReadKey();  
        }
        static double Calc(double a, double b, double c)
        {
            return Math.Sqrt((a+Math.Pow(Math.E, b))/c);
        }
    }
}
