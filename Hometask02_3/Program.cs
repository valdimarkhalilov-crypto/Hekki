//Задайте массив из 10 элементов, заполненный числами от -10 до 10.
//Замените отрицательные числа на их абсолютные значения, а положительные числа
//на их отрицательные эквиваленты.
using System;
using System.Reflection.Emit;
namespace Hometask02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 11);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = Math.Abs(array[i]);
                }
                else if (array[i] > 0)
                {
                    array[i] = -array[i];
                }
            }

            Console.WriteLine("Преобразованный массив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
