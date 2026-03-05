// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
    int secondDigit = (num / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {num} - {secondDigit}");
}
else
{
    Console.WriteLine("Введённое число не является трёхзначным.");
}