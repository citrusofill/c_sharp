// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Line (int [] coefficient, string name)
{
Console.WriteLine ($"Введите коэффициенты  (b k) для линии: {name}");
coefficient = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Clear();
}


int [] line1 = new int [2];
int [] line2 = new int [2];

Line (line1, "Прямая 1");
Line (line2, "Прямая 2");

Console.WriteLine($"[{string.Join(", ", line1)}]");
Console.WriteLine($"[{string.Join(", ", line2)}]");

//double crossX = (line1[0]-line2[0])/(line2[1]-line1[1]);
//double crossY = crossX*line1[1]+line1[0];

//Console.WriteLine ($"Координаты точки пересечения: Х= {crossX}; Y= {crossY}");