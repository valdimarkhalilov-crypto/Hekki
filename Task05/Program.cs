// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number % 10;
Console.WriteLine($"Последняя цифра числа {number} равна {lastDigit}");