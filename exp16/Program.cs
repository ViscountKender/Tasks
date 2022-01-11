Console.WriteLine("Введите номер дня недели - ");
long number = Convert.ToInt32(Console.ReadLine());
if (0 >= number || number > 8  )
{
    Console.WriteLine(" Неверный номер недели");
    Environment.Exit(0);
}
if (number == 6 || number == 7 )
{
    Console.WriteLine(" Выходной день");
}
else
{
    Console.WriteLine(" Рабочий день");
}
