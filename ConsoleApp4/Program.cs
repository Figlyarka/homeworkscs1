using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "теплоход";
            string holod = word.Substring(5, 2) + word.Substring(3, 2) + word.Substring(7, 1);
            string delo = word.Substring(7, 1) + word.Substring(1, 1) + word.Substring(3, 2);
            Console.WriteLine(holod);
            Console.WriteLine(delo);
            Console.ReadKey();
        }
    }
}
