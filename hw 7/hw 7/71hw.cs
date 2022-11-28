using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_7
{
    internal class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if ((k > 0 || m > 0 || n > 0) && (k % 2 == 0 || m % 2 == 0 || n % 2 == 0));
            Console.WriteLine("True");
            
            else
            { 
                Console.WriteLine("False");
        }
    }
}
