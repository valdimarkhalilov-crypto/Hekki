//Задайте массив из 10 целых чисел. Найдите среднее значение элементов
//массива.
using System;
namespace Hometask03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();

            Console.WriteLine("Массив из 10 целых чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 11);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            double average = array.Average();
            Console.WriteLine($"Среднее значение элементов массива: {average}");
        }
    }
}