using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args) // Сумма чётных чисел в заданном массиве
        {
            int[] array = new int[10] {81,22,13,54,10,34,15,26,71,68};
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result += array[i];
                }
            }
            Console.WriteLine($"Сумма чётных чисел в заданном массиве = {result}");
            Console.ReadKey();
        }
    }
}