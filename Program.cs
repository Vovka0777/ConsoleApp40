using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40_4
{
    delegate int Sum(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Sum sum = Summa.Sum;

            Console.Write("Введите первое число - ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число - ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int result = sum(a, b);
            Console.WriteLine(result);
            Console.WriteLine();
            Console.Write("Введите первое число - ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число - ");
            b = int.Parse(Console.ReadLine());
            result = sum(a, b);
            Console.WriteLine(result);
            Console.WriteLine();
            Console.Write("Введите первое число - ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число - ");
            b = int.Parse(Console.ReadLine());
            result = sum(a, b);
            Console.WriteLine(result);
        }
    }
}
