using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args) // Индекс первого вхождения в массив
        {
            int[] array = new int[10] {81,22,13,34,10,34,15,26,71,68};

            int result1 = Array.IndexOf(array, 34);
            int result2 = Array.IndexOf(array, 55);

            Console.WriteLine($"Индекс элемента массива \"34\" = {result1}");
            Console.WriteLine($"Элемент массива \"55\" не найден = {result2}");

            Console.ReadKey();
        }
    }
}