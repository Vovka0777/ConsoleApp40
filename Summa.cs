using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40_4
{
    class Summa
    {
        public static int Sum(int a, int b)
        {
            Console.WriteLine($"Сумма чисел от {a} до {b}:");
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;

            }
            return sum;
        }
    }
}
