#define Task1
#define Task2
#define Task3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static readonly string delimiter = "------------------------------------------------------";
        static void Main(string[] args)
        {
#if Task1
            Console.WriteLine("Введите высоту прямоугольника");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Прямоугольник");

            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j <= width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter);

            Console.WriteLine("Введите высоту треугольников");
            height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /* for (int i = 0; i < height; i++)
             {
                 Console.SetCursorPosition(height - i, i + 1);
                 for (int j = 0; j <= i; j++)
                 {
                     Console.Write("*");
                 }
             }*/

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter);

            Console.WriteLine("Фигура - ромб");

            for (int i = 0; i < height; i++)
            {
                //верхняя часть ромба
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                Console.WriteLine();
            }
            //нижняя часть ромба
            for (int i = height - 1; i >= 0; i--)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                Console.WriteLine();
            }
            Console.WriteLine(delimiter);

            Console.WriteLine("Фигура №6");
            Console.WriteLine("Введите размер фигуры");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write("+");
                        }

                    }
                }
                Console.WriteLine();
            }
#endif
#if Task2
            Console.WriteLine("Введите размер клетки");
            int cell = int.Parse(Console.ReadLine());
            for (int c = 0; c < cell; c++)
            {
                if (c % 2 == 0)
                {
                    for (int n = 0; n < cell; n++)
                    {
                        for (int l = 0; l < cell; l++)
                        {
                            if (l % 2 == 0)

                            {
                                for (int j = 0; j < cell; j++)

                                {
                                    Console.Write("* ");
                                }


                            }
                            else
                            {
                                for (int m = 0; m < cell; m++)
                                {
                                    Console.Write("  ");
                                }
                            }
                        }
                        Console.WriteLine();
                    }

                }

                else
                {
                    for (int n = 0; n < cell; n++)
                    {
                        for (int l = 0; l < cell; l++)
                        {
                            if (l % 2 == 0)

                            {
                                for (int j = 0; j < cell; j++)

                                {
                                    Console.Write("  ");
                                }
                                //cout << "\n";

                            }
                            else
                            {
                                for (int m = 0; m < cell; m++)
                                {
                                    Console.Write("* ");
                                }
                            }
                        }
                        Console.WriteLine();
                    }



                }
            }
#endif
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}


