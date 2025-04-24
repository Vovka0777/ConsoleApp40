using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40_3
{
    internal class Program
    {
        delegate double Averagion(int a, int b);
        //delegate void Message(string str);
        static void Main(string[] args)
        {
            Averagion del = Average.Averagee;
            double result = del.Invoke(1,5);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
