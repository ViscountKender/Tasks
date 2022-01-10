Random random = new Random();
int n ;
n = random.Next(1,99999);
if (n <100)
{
    Console.WriteLine("Третьей цифры нет");
}
 string Stringnumer = Convert.ToString(n);
Console.WriteLine(n);
Console.WriteLine(" Третья цифра числа " + Stringnumer[2]);