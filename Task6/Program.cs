using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static void Main(string[] args)
        {



        }
    }
}
