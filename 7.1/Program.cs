using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("напишите 3 числа");
            int k = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Results(k,m,n));
            Console.ReadKey();
        }
        static bool Results(int k,int m,int n)
        {
            if (((k > 0) || (m > 0) || (n > 0)) && ((k % 2 == 0) || (m % 2 == 0) || (n % 2 == 0)))
            {
                return true;
            }
            return false;
            
        }
    }
}
