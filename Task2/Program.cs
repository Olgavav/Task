//Напишите программу,
// которая принимает на вход три числа и выдает максимальное из этх чисел
Console.WriteLine("Введите число три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{Console.WriteLine("number max="+number1);}
else
if (number2>number3)
{Console.WriteLine("number max="+number2);}
else
if (number3>number1)
{Console.WriteLine("number max="+number3);}