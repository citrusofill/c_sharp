// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

void InputMatrix (int [,] matrix)
{
    for (int i = 0; i<matrix.GetLength(0);i++)
    {
        for (int j = 0; j<matrix.GetLength(1);j++)
        {
        matrix[i,j] = new Random().Next (-10,11); //-10, +10
        }
    }
}

int MinStr (int [,] matrix)
{
int minIndex = 1;
int min=0;
    for (int i = 0; i<matrix.GetLength(0);i++)
    {
        int minTemp = matrix[i,0];

        for (int j = 1; j<matrix.GetLength(1);j++)
        {
         minTemp = minTemp + matrix[i,j];
        }
        if (i == 0)  min = minTemp;
        if (minTemp < min)  
            {
                min = minTemp;
                minIndex = i + 1;
            }
    }
    
return minIndex;
}

void PrintMatrix (int [,] matrix)
{
       for (int i = 0; i<matrix.GetLength(0);i++)
    {
        for (int j = 0; j<matrix.GetLength(1);j++)
        {
            Console.Write($"{matrix[i,j]} \t");
        }
           Console.WriteLine ();
    }
}

Console.WriteLine ("Введите размер матрицы m x n:");
int [] size = Console.ReadLine().Split (" ").Select (x=>int.Parse(x)).ToArray();
int [,] matrix = new int [size[0],size[1]];
Console.Clear();
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine ("______________");
Console.WriteLine($" Строка №{MinStr(matrix)} имеет наименьшую сумму");