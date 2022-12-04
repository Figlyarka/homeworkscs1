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
            Console.WriteLine("Введите х и у");
            double x=double.Parse(Console.ReadLine());
            double y=double.Parse(Console.ReadLine());
            Console.WriteLine(Isdotinarea(x,y));
            
        }
        static bool Isdotinarea(double x,double y)
        {
            if ((y >= -2) && ((x <= -3) || (x >= -1)))
            {
                return true;
            }
            return false;   
        }
    }
}
