/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число:");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int d = Convert.ToInt32(Console.ReadLine());


if (c>d)
Console.WriteLine("число: "+ c + " больше чем число: "+ d);
else if (c<d)
Console.WriteLine("число: "+ d + " больше чем число: "+ c);
else
Console.WriteLine("число: "+ c + " равно числу: "+ d);