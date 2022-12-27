// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D 
// пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
 Console.WriteLine ("Введите число:");
Double ax = Convert.ToDouble(Console.ReadLine ());
Double ay = Convert.ToDouble(Console.ReadLine());
Double az = Convert.ToDouble(Console.ReadLine());
Double bx = Convert.ToDouble(Console.ReadLine ());
Double by = Convert.ToDouble(Console.ReadLine());
Double bz = Convert.ToDouble(Console.ReadLine());


Double Z = Math.Sqrt(Math.Pow((bx-ax),2) + Math.Pow((by-ay),2) + Math.Pow((bz-az),2));

Console.WriteLine(Z);