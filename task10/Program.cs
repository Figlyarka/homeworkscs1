using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    internal class Program
    {
        static void Main()
        {   
            
            Console.WriteLine("Введите число <=18446774073709551615");
            string n = Console.ReadLine();
            int[] array = new int[n.Length];
            int num = Convert.ToInt32(n);
            for (int i = 0; i < n.Length; i++)
            {
                array[i] = num % 10;
                num /= 10;
            }
            EnterArrayWithSemicolon(array);
            Console.WriteLine("Введите число по модулю равное 10");
            int module = int.Parse(Console.ReadLine());
            ArraysChanges(array, n, module);
            Summary(array, n, module);
            ReplaceArray(array, n);
            Console.ReadKey();  
        }
        static void EnterArrayWithSemicolon(int[] array)
        {
            string s = String.Join("; ", array);
            Console.WriteLine(s);
        }
        static void ArraysChanges(int[] array, string n, int module)
        {
            for (int i=0; i< array.Length; i++)
            {
                array[i] = module + array[i];
            }
            string str = String.Join(" ", array);
            Console.WriteLine(str);
        }
        static void Summary(int[] array, string n,int module)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
        static void ReplaceArray(int[] array,string n)
        {
            for (int i=0;i<n.Length-1;i+=2)
            {
                (array[i], array[i + 1]) = (array[i+1], array[i]);    

            }
            string str = String.Join(" ", array);
            Console.WriteLine(str);
        }
    }
}
