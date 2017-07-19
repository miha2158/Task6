using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                WriteLine("Произошла ошибка. {0}",msg);

            return n;
        }


        static void Main(string[] args)
        {
            WriteLine("Введите первые 3 элемента числовой последовательности\n");

            double a0 = ReadNum("Введите 1-й элемент");
            double a1 = ReadNum("Введите 2-й элемент");
            double a2 = ReadNum("Введите 3-й элемент");

            WriteLine();
            double m = ReadNum("Введите искомое число");
            double n = ReadNum("Введите количество элементов последовательности");





            ReadKey(true);
        }
    }
}