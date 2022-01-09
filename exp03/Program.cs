String [] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите номер дня недели - ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(week[number -1]);
