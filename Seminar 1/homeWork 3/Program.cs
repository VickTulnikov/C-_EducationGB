Console.WriteLine("Данная программа определит является ли число четным");
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if(a%2==1)
{
    Console.WriteLine("Число нечетное");
}
else 
{
    Console.WriteLine("Число четное");
}