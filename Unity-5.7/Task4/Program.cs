using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args) // Сортировка выбором
        {
            int[] array = new int[10] {6,8,3,5,9,10,7,2,4,1};
            int num = 0;

            Console.Write("Изначальный массив: ");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        num = array[j];
                        array[j] = array[j+1];
                        array[j + 1] = num;
                    }
                }
            }

            Console.Write("\nОтсортированный массив: ");
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}