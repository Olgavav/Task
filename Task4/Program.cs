//Напишите программу,
//которая на вход принимает число (n), а на выход показывает все четные числа от 2 до N
Console.WriteLine("Введите число: ");
Console.Write("n=");
int n= Convert.ToInt32(Console.ReadLine());
for(int i=1; i<n; i++)
{if(i%2 == 0)

Console.WriteLine(i);}