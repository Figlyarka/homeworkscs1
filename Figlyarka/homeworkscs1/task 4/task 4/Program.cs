using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(x + (Math.Abs(x + Math.Abs(x + Math.Sqrt(x + 1))))));
            Console.ReadKey();
        }
    }
}
