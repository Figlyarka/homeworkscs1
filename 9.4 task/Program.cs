using System;


namespace TheBestMarksOfGroup
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число групп");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число студентов");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите чилсло экзаменов");
            int k = int.Parse(Console.ReadLine());
            int countN = 0;
            int countM;
            int countK;
            int bestMark = 0;
            int bestGroup = -1;
            while (countN < n)
            {
                countN++;
                countM = 0;
                int MarkOfGroup = 0;

                while (countM < m)
                {
                    countM++;
                    countK = 0;
                    while (countK < k)
                    {
                        countK++;
                        Console.WriteLine($"введите оценку студента группы {countN} номер в списке{countM} по экз.номер{countK}");
                        int Mark = int.Parse(Console.ReadLine());
                        MarkOfGroup += Mark;

                        if (MarkOfGroup > bestMark)
                        {
                            bestGroup = countN;
                            bestMark = MarkOfGroup;
                        }

                    }
                }

            }
            if (bestGroup != -1)
                Console.WriteLine($"Лучшая группа № {bestGroup} со средним баллом {bestMark / (k * m)}");
            else
                Console.WriteLine("Лучшая группа не найдена");
        }
    }
}



