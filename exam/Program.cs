using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зачет
{
    internal class Program
    {
        static void Main()
        {
            List<char> vowels = new List<char> { 'а', 'о', 'ы', 'и', 'у', 'э', 'ё', 'я', 'е', 'ю', 'А', 'О', 'Ы', 'И', 'У', 'Э', 'Ё', 'Я', 'Е', 'Ю' };
            Console.WriteLine("введите строку на русском языке");
            string str = Console.ReadLine();
            int all = 0;
            if (IsRightStr(str))
            {
                for (int i = 0; i < vowels.Count / 2; i++)
                {
                    int count = 0;
                    if (str.Contains(vowels[i]))
                    {
                        count = str.Count(s => s.Equals(vowels[i]));
                        count += str.Count(s => s.Equals(vowels[i + 10]));
                        Console.WriteLine($"Буква {vowels[i]} вcтречается {count} раз");
                        all += count;

                    }

                }

                Console.WriteLine(all + " общее количество гласных");
            }
            else
            {
                Console.WriteLine("");
            }



            Console.ReadKey();
        }
        static bool IsRightStr(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (Char.IsLetter(c) || Char.IsPunctuation(c))
                {
                    count++;
                }
            }
            if (count == str.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}