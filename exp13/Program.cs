Console.WriteLine("введите первое число ");
decimal num1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("введите второе число ");
decimal num2 = Convert.ToInt64(Console.ReadLine());
decimal result = (num1 % num2);
if ( result == 0 )
{
    Console.WriteLine("первое число кратно второму ");
}
else 
{
    Console.WriteLine("число не кратно остаток от деления " + result);
}
    
