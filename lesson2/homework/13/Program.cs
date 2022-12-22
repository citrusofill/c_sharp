// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.(можно использовать индексацию строк)

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine ("Введите число:");
string a = Console.ReadLine();
int b = a.Length;
if (b<3) Console.WriteLine("Третьей цифры нет!");
else Console.WriteLine (a.Substring (2,1));