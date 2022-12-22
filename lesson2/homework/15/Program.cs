// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//  является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.WriteLine ("Введите день недели:");
int a = Convert.ToInt32(Console.ReadLine());
if (a>5 && a<8) Console.WriteLine("Является выходным днем");
else if (a>0 && a<6) Console.WriteLine( "Не является выходным днем");
else Console.WriteLine("Ошибка ввода"); 