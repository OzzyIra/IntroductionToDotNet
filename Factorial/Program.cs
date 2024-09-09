using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    
    class Program
    {
   
        static int CalculateFactorial(int number)
        {
            if (number == 0 || number == 1) return 1;
           
             int sum = 1;
                for (int i = 1; i <= number; i++)
                {

                    sum *= i;
                }
                return sum;     
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше число");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(number));
           
        }

    }
        
}
