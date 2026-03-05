// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели (1-7):");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
if (dayOfWeek >= 1 && dayOfWeek <= 7)
{
    if (dayOfWeek == 6 || dayOfWeek == 7)
    {
        Console.WriteLine("Это выходной день.");
    }
    else
    {
        Console.WriteLine("Это рабочий день.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 7.");
}