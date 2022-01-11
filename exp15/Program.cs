Random random = new Random();
int n ;
n = random.Next(1,99999);
int number = n;
int result1 = n % 7;
int result2 = n % 23;
if (result1 == 0 && result2 == 0 )
{
    Console.WriteLine($"число {n} кратно 7 и 23 ");
}

else
{
    Console.WriteLine($"число {n} некратно 7 и 23");
}