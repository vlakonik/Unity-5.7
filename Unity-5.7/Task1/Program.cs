using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args) // Сумма чётных чисел заданного диапазона
        {
            int result = 0;

            for (int i = 7; i < 22; i++)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }
            }

            Console.WriteLine($"Сумма чётных чисел в диапазоне от 7 до 21 = {result}");
            Console.ReadKey();
        }
    }
}