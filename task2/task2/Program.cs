using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ОБЪЕМ=");
            Console.WriteLine(a * b * c);
            Console.WriteLine("ПЛОЩАДЬ ПОВЕРХНОСТИ=");
            Console.WriteLine(2*(a*c+c*b+a*b));
            Console.ReadKey();

        }
    }
}
