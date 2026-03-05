// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Random random = new Random();
int number = random.Next(10, 100);
Console.WriteLine($"Случайное число: {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра: {firstDigit}");
}
else if (secondDigit > firstDigit)
{
    Console.WriteLine($"Наибольшая цифра: {secondDigit}");
}
else
{
    Console.WriteLine("Обе цифры равны");
}