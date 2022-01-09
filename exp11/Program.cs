Random random = new Random();
int n ;
n = random.Next(10,99);
Console.WriteLine("Рандомное число " + n);
int number = n % 10;
int number1 = n / 10;
if ( number1 > number)
{
    Console.WriteLine("Наибольшая цифра " + number1);
    
}
if (number > number1)
{
    Console.WriteLine("Наибольшая цифра " + number);
}
if (number == number1)
{
     Console.WriteLine("числа одинаковые");
}

