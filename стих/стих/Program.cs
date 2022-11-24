using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The Labrador Puppies");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("I see them now,\r\nThey neither moo nor meow.\r\nHands are small, oh that’s the paw!\r\nWill you look at that tiny little claw.", ConsoleColor.Magenta);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
