Console.WriteLine("Введите х не равный нулю ");
int x = int.Parse(Console.ReadLine());
if (x == 0)
{
    Console.WriteLine("Вай ты баран ввел  х равный нулю ");

}
int y = 3 / x * x * x - 8;
Console.WriteLine("F = " + y);
