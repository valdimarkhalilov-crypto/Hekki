//Задайте массив целых чисел. Напишите программу, которая удаляет все
//отрицательные числа из массива и возвращает новый массив, содержащий только
//неотрицательные числа.
using System;
using System.Linq;
namespace Hometask04_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив целых чисел через пробел:");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] nonNegativeArray = array.Where(num => num >= 0).ToArray();

            Console.WriteLine("Массив без отрицательных чисел:");
            foreach (int num in nonNegativeArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}