using System;

using static System.Console;

namespace Task6
{
    class Program
    {
        static void Swap(ref double a, ref double b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        static void iterrate(ref double a, ref double b, ref double c)
        {
            double result = a + b / 3 + c * 3;
            c = b;
            b = a;
            a = result;
        }

        static double ReadNum(string msg)
        {
            WriteLine(msg);
            double n;

            while (!double.TryParse(ReadLine().Replace(".",","), out n))
                WriteLine("Произошла ошибка. Введите число");

            return n;
        }


        static void Main(string[] args)
        {
            WriteLine("Введите первые 3 элемента числовой последовательности\n");

            double a2 = ReadNum("Введите 1-й элемент");
            double a1 = ReadNum("Введите 2-й элемент");
            double a0 = ReadNum("Введите 3-й элемент");

            WriteLine();
            double m = ReadNum("Введите искомое число");
            int n = 1 + (int)ReadNum("Введите количество элементов последовательности");
            int i = 0;
            string nums = string.Empty;

            while (n-- > 0)
            {
                i++;
                if (Math.Abs(m - a2) < 0.000001)
                    nums += " " + i;
                iterrate(ref a0, ref a1, ref a2);
            }

            if (nums == string.Empty)
                nums = "Таких нету";
            WriteLine("Элементы последовательности совпадающие с числом {0}:\n'{1}'", m, nums);

            ReadKey(true);
        }
    }
}