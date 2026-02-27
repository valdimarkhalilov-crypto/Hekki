Console.Write("Введите количество гирь: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Вес гири #{i+1}: ");
    array[i] = int.Parse(Console.ReadLine());
}

// получить максимум через LINQ
int max = array.Max();
Console.WriteLine($"max = {max}");

