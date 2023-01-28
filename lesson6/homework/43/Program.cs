// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Line (double [] coefficient, string name)
{
Console.WriteLine ($"Введите коэффициенты  (b k) для линии: {name}");
int[] temp = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
for (int i = 0;i <= 1; i++)
coefficient[i] = temp[i];
Console.Clear();
}


double [] line1 = new double [2];
double [] line2 = new double [2];

Line (line1, "Прямая 1");
Line (line2, "Прямая 2");

Console.WriteLine($"[{string.Join(", ", line1)}]");
Console.WriteLine($"[{string.Join(", ", line2)}]");

double crossX = (line1[0]-line2[0])/(line2[1]-line1[1]);
double crossY = crossX*line1[1]+line1[0];

Console.WriteLine ($"Координаты точки пересечения: Х= {crossX}; Y= {crossY}");