Console.WriteLine("What is your name?");
string? username = Console.ReadLine();
if (username == "Маша")
{
    Console.WriteLine("Приветствую тебя, Маша! Очень давно не виделись!");
}
else
{
     Console.WriteLine("Приветствую тебя, " + username + "!");
}
