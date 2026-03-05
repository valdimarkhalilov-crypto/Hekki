//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
//на само себя).

//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49
//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int square = number * number;
//Console.WriteLine($"Квадрат числа {number} равен {square}");
// Написать программу, которая спрашивает у пользователя число и степень,
// в которую нужно возвести это число, и выводит результат на экран.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
long result = (long)Math.Pow(num, degree);
Console.WriteLine($"Результат: {result}");