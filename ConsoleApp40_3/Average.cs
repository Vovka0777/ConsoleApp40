using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40_3
{
    
    class Average
    {
        public static void Message(string str)
        {
            Console.WriteLine(str);
        }
        public static double Averagee(int a, int b)
        {
            Message($"Среднее арифметическое чисел от {a} до {b}:");
            double sum = 0;    
            double count = 0;
            for (int i = a; i <= b; i++)
            {
                sum +=i;
                
            }
            return sum / (b-a+1);
        }
    }
}
