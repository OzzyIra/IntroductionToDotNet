﻿//#define NUMERIC_TYPES
//#define LITERALS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static readonly string delimiter1 = "\n-------------------------------------------------\n";
        static readonly string delimiter2 = "\n=================================================\n";
        static void Main(string[] args)
        {
#if NUMERIC_TYPES
            Console.WriteLine("C# DataTypes");
            #region Boolean
            //Console.WriteLine(bool.TrueString);
            //Console.WriteLine(Convert.ToBoolean(100));

            //Console.WriteLine(bool.Parse("falsE"));
            #endregion
            Console.Write($"Переменная типа char занимает {sizeof(short)} байта памяти");
            Console.WriteLine($"и принимает значения в диапозоне: {short.MinValue}....{short.MaxValue}");
            Console.Write($"Диапозон принимаемых значений 'ushort': {ushort.MinValue}....{ushort.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.Write($"Переменная типа Int16 занимает {sizeof(Int16)} байта памяти");
            Console.WriteLine($"и принимает значения в диапозоне: {Int16.MinValue}....{short.MaxValue}");
            Console.Write($"Диапозон принимаемых значений 'UInt16': {UInt16.MinValue}....{ushort.MaxValue}");
            Console.WriteLine(delimiter2);
            Console.WriteLine();

            Console.Write($"Переменная типа int занимает {sizeof(int)} байта памяти");
            Console.WriteLine($"и принимает значения в диапозоне: {int.MinValue}....{uint.MaxValue}");
            Console.Write($"Диапозон принимаемых значений 'uint': {uint.MinValue}....{uint.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.Write($"Переменная типа Int32 занимает {sizeof(Int32)} байта памяти");
            Console.WriteLine($"и принимает значения в диапозоне: {Int32.MinValue}....{Int32.MaxValue}");
            Console.Write($"Диапозон принимаемых значений 'UInt32': {UInt32.MinValue}....{UInt32.MaxValue}");
            Console.WriteLine(delimiter2);

#endif
#if LITERALS
            Console.WriteLine(123.GetType());   //int
            Console.WriteLine(123u.GetType());  //uint    
            Console.WriteLine(123l.GetType()); //long    
            Console.WriteLine(123UL.GetType()); //long

            Console.WriteLine(5d.GetType());    //double
            Console.WriteLine(123.4.GetType()); //double
            Console.WriteLine(123f.GetType());  //float
            Console.WriteLine(123m.GetType());  //decimal
#endif
            Console.WriteLine(((byte)5).GetType().Name);



        }
    }
}
