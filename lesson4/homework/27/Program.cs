/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
 Console.WriteLine ("Введите число:");
string a = Console.ReadLine();
int b = a.Length;
double c = 0;
for (int i=0; i<b; i++) c =c + Char.GetNumericValue (a[i]);
Console.WriteLine (c);