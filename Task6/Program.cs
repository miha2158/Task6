using System;
using System.Collections.Generic;

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

        static void iterrate(ref decimal a, ref decimal b, ref decimal c)
        {
            decimal result = a + b / 3 + c * 3;
            c = b;
            b = a;
            a = result;
        }

        static decimal ReadNum(string msg)
        {
            WriteLine(msg);
            decimal n;

            while (!decimal.TryParse(ReadLine().Replace(".",","), out n))
                WriteLine("Произошла ошибка. Введите число");

            return n;
        }


        static void Main(string[] args)
        {
            WriteLine("Введите первые 3 элемента числовой последовательности\n");

            decimal a2 = ReadNum("Введите 1-й элемент");
            decimal a1 = ReadNum("Введите 2-й элемент");
            decimal a0 = ReadNum("Введите 3-й элемент");

            WriteLine();
            decimal m = ReadNum("Введите искомое число");
            int n = 1 + (int)ReadNum("Введите количество элементов последовательности");
            int i = 0;
            var nums = new List<double>(0);

            Write("Последовательность:");
            while (n-- > 0)
            {
                i++;
                Write(" {0}", a0);
                if (Math.Abs(m - a2) < 0.000001M)
                    nums.Add(1);
                iterrate(ref a0, ref a1, ref a2);
            }

            if (nums.Count == 0)
                WriteLine("Элементов совпадающих с {0} нету", m);
            else
            {
                WriteLine("С числом {0} совпадает: {1} элементов", m, nums.Count);
                Write("Элементы:");
                foreach (double d in nums)
                    Write(" {0}", d);
            }

            ReadKey(true);
        }
    }
}