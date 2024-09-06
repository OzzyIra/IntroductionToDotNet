//#define OUTPUT_TO_SCREEN
using System;
using System. Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
 #if OUTPUT_TO_SCREEN


            Console.Title = "Introduction to .NET"; // вывод на экран
            Console.WriteLine("Hello.NET");

            Console.BackgroundColor = ConsoleColor.Blue;    //цвет фона
            Console.ForegroundColor = ConsoleColor.Black;    //цвет текста

            // Console.CursorLeft = 20;    //координата курсора по оси 'X'
            // Console.CursorTop = 12;     //координата курсора по оси 'Y'
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("Вот так задаются координаты");
            Console.ResetColor();       //применяет цветовую схему по умолчанию

            //задаем размеры окна
            //Console.WindowWidth = 64;
            //Console.WindowHeight = 32;
            Console.SetWindowSize(64, 16);

            //задаем положение окна на экране
            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;

            //Console.SetWindowPosition(10, 10);

            //задаем размер буфера консоли
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
#endif
            Console.WriteLine("Введите ваше имя: ");
            string first_name = Console.ReadLine();//читает строку с клавиатуры до нажатия enter и возвращает прочитанную строку
            //Console.WriteLine(first_name);

            Console.WriteLine("Введите фашу фамилию: ");
            string last_name = Console.ReadLine();
            //Console.WriteLine(last_name);

            Console.WriteLine("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);

            Console.WriteLine(last_name + " " + first_name + " " + age + "years");    // конкатенация строк
            Console.WriteLine(String.Format("{0} {1} {2} years",last_name,first_name,age)); // форматирование
            Console.WriteLine($"{last_name} {first_name} {age} years");    //Интерполяция строк - изменение, искажение

        }
    }
}
