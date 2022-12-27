//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine ("Введите число:");
string a = Console.ReadLine();
int b = a.Length;
int j = 0;
for (int i=0; i<b/2; i++)
{
if (a[i] == a[b-1-i]) j=j+1;
}
if (j==b/2) Console.WriteLine (" -> является");
else Console.WriteLine ("-> не является");

// Сделал для чисел и символов любой длины.