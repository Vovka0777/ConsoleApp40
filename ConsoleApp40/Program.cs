using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Program
    {
        delegate void Message(); // 1 Шаг. Объявление делегата
        static void Main(string[] args)
        {
            Message message; // 2 Шаг. Создание объекта делегата 
            Message goodbye;
            Message goodmorning;
            Message goodevening;

            goodmorning = GoodMorning;
            goodevening = GoodEvening;
            message = Hello;// 3 Шаг. Связывание объект делегата с методом
            goodbye = Bye;
            message();// 4 Шаг. Выозов метода
            goodbye();

            if (DateTime.Now.Hour <= 12)
            {
                goodmorning();
            }
            else
            {
                goodevening();
            }
            Console.Read();
        }
        static public void Hello()
        { Console.WriteLine("Привет!"); }
        static public void Bye()
        { Console.WriteLine("Пока!"); }
        static public void GoodMorning() 
        {
            Console.WriteLine("Доброе утро!");
        }
        static public void GoodEvening() 
        {
            Console.WriteLine("Добрый вечер!");
        }
    }
}
