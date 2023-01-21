//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
 Console.WriteLine ("Введите число:");
int a = Convert.ToInt16(Console.ReadLine ());

 Console.WriteLine ("Введите степень:");
int b = Convert.ToInt16(Console.ReadLine());

Console.WriteLine (Math.Pow(a,b));