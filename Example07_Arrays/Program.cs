int[] arrays = {1, 12, 31, 4, 15, 16, 17, 18};

int n = arrays.Length;
if (int.TryParse(Console.ReadLine(), out int find))
{
    // ваш код поиска
}
else
{
    Console.WriteLine("Некорректный ввод");
}
int index = 0;

while (index < n)
{
    // use == for comparison, not = (assignment)
    if (arrays[index] == find)
    {
        Console.WriteLine(index);
        break; // found — exit loop
    }
    index++;
}
// If index == n, element was not found
if (index == n)
{
    Console.WriteLine("Not found");
}