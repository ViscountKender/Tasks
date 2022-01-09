Random random = new Random();
int n ;
n = random.Next(100,999);
int num3 = n % 10;
int num1 = n / 100;
Console.WriteLine($"{num1}{num3}");
Console.WriteLine(n);