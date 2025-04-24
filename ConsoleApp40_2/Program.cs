using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40_2
{
    internal class Program
    {
        delegate double Operation(int a, int b);
        static void Main(string[] args)
        {
            // присваивание адреса метода через конструктор
            Operation del = new Operation(Add); // делегат указывает на метод Add
            double result = del.Invoke(4, 5);
            Console.WriteLine(result);
            del = Minus; // теперь делегат указывает на метод Minus
            result = del(4, 5);
            Console.WriteLine(result);
            del = Multiply;
            result = del(4, 5);
            Console.WriteLine(result);
            del = Delit;
            result = del(12,3);
            Console.WriteLine(result);
            Console.Read();

            Console.Read();
        }
        static public double Add(int a, int b)
        {
            return a + b; 
        }
        static public double Minus(int a, int b)
        {
            return a - b;
        }
        static public double Multiply(int a, int b)
        {
            return a * b;
        }
        static public double Delit(int a, int b)
        {
            return a/b;
        }
    }
}
