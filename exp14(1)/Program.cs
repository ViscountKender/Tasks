Random random = new Random();
int n ;
n = random.Next(1,99999);
int number = n;
if (n <100)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    for (int i = 0; n  > 1000; i++)
{
    n = n / 10;
}
n = n % 10;
Console.WriteLine(number);
Console.WriteLine("Третья цифра числа " + n);

}

