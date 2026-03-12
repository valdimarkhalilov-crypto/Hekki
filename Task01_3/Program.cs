//Задайте массив целых чисел. Напишите программу, которая проверяет,
//присутствует ли заданное число в массиве. Программа должна вывести:
//Присутствует/Не присутствует.
using System;
using System.Linq;
namespace Task01_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив целых чисел через пробел:");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Введите число для проверки:");
            int numberToCheck = int.Parse(Console.ReadLine());

            if (array.Contains(numberToCheck))
            {
                Console.WriteLine("Присутствует");
            }
            else
            {
                Console.WriteLine("Не присутствует");
            }
        }
    }
}