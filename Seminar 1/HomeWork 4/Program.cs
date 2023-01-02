// Данная программа выводит на экран все четные числа от 1 до заданного числа
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

for(int i =1 ; i <= n; i++)
    if(i%2==0)
       Console.WriteLine(i);