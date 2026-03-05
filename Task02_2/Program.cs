// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine($"Число без второй цифры: {result}");