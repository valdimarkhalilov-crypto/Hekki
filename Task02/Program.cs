// Напишите программу, которая принимает два числа и проверяет, 
// является ли одно число квадратом другого.
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine($"{num1} является квадратом {num2}");
}
else if (num2 == num1 * num1)
{
    Console.WriteLine($"{num2} является квадратом {num1}");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}