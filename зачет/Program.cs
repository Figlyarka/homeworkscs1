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
            

            Console.WriteLine("Введите строку на русском языке");
            string sentance = Console.ReadLine();
            if (AreAllLetters(sentance))
            {
                string phrase2 = sentance;
                phrase2 = phrase2.Replace("а", "1");
                phrase2 = phrase2.Replace("о", "2");
                phrase2 = phrase2.Replace("у", "3");
                phrase2 = phrase2.Replace("е", "4");
                phrase2 = phrase2.Replace("ы", "5");
                phrase2 = phrase2.Replace("ё", "6");
                phrase2 = phrase2.Replace("э", "7");
                phrase2 = phrase2.Replace("ю", "8");
                phrase2 = phrase2.Replace("я", "9");
                phrase2 = phrase2.Replace("и", "0");
                Console.WriteLine(phrase2);
                int a = 0;
                int o = 0;
                int u = 0;
                int e = 0;
                int p = 0;
                int yo = 0;
                int ee = 0;
                int yu = 0;
                int ya = 0;
                int ii = 0;
                for (int i=0; i<phrase2.Length;i++)
                {
                    if (phrase2[i]==Convert.ToChar("1"))
                    {
                        a++;
                    }
                    if (phrase2[i]== Convert.ToChar("2"))
                    {
                        o++;
                    }
                    if (phrase2[i]== Convert.ToChar("3"))
                    {
                        u++;
                    }
                    if (phrase2[i]== Convert.ToChar("4"))
                    {
                        e++;
                    }
                    if (phrase2[i] == Convert.ToChar("5"))
                    {
                        p += 1;
                    }
                    if (phrase2[i] == Convert.ToChar("6"))
                    {
                        yo += 1;
                    }
                    if (phrase2[i] == Convert.ToChar("7"))
                    {
                        ee++;
                    }
                    if (phrase2[i] == Convert.ToChar("8"))
                    {
                        yu++;
                    }
                    if (phrase2[i] == Convert.ToChar("9"))
                    {
                        ya++;
                    }
                    if (phrase2[i] == Convert.ToChar("0"))
                    {
                        ii++;
                    }

                }
                Console.WriteLine(a + "колво а");
                Console.WriteLine(o + "колво о");
                Console.WriteLine(u + "колво у");
                Console.WriteLine(e + "колво е");
                Console.WriteLine(p + "колво ы");
                Console.WriteLine(yo + "колво ё");
                Console.WriteLine(ee + "колво э");
                Console.WriteLine(yo + "колво ё");
                Console.WriteLine(yu + "колво ю");
                Console.WriteLine(ya + "колво я");

                int allvowels = a + o + u + e + p + yo + ee + yo + yu + ya;
                Console.WriteLine( allvowels + " общее количество гласных");
            }
            else
            {
               Console.WriteLine("неверный формат");
            }
            


            Console.ReadKey();
        }

        static bool AreAllLetters(string sentance)
        {
            int count = 0;
            foreach (char c in sentance)
            {
                if (Char.IsLetter(c))
                {
                    count++;
                }

            }
            if (count < sentance.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
