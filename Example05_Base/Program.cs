using System.Security.Cryptography;

int baseValue = RandomNumberGenerator.GetInt32(0, 100);
int count = 0;
Console.WriteLine("Введите количество итераций:");
int a = int.Parse(Console.ReadLine());
while (count<a)
{    int randomValue = RandomNumberGenerator.GetInt32(0, 100);
    if (randomValue > baseValue)
    {
        Console.WriteLine($"Случайное число {randomValue} больше базового {baseValue}");
    }
    else if (randomValue < baseValue)
    {
        Console.WriteLine($"Случайное число {randomValue} меньше базового {baseValue}");
    }
    else
    {
        Console.WriteLine($"Случайное число {randomValue} равно базовому {baseValue}");
    }
    count++;
}
