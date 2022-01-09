Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
{
    Console.WriteLine("Числа равны ");
}
if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}

if (number1 < number2)
{
   Console.WriteLine($"Число {number1} меньше числа {number2}");
}