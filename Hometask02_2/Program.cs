// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numStr = num.ToString();
if (numStr.Length >= 3)
{
    Console.WriteLine($"Третья цифра числа {num} - {numStr[2]}");
}
else
{
    Console.WriteLine($"У числа {num} нет третьей цифры");
}