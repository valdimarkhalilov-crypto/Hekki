DateTime now = DateTime.Now;
string[] daysOfWeek = { "Воскресенье", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
Console.WriteLine($"Сегодня: {daysOfWeek[(int)now.DayOfWeek]}");