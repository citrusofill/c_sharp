// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void Sort (int [,] matrix)
{
    for (int i = 0; i<matrix.GetLength(0);i++)
    {
       for (int iter = 0; iter<matrix.GetLength(1)-1;iter++)
       {
        for (int j = 1; j<matrix.GetLength(1);j++)
        {
            if (matrix[i,j] > matrix[i,j-1])
            {
             int temp = matrix[i,j]; 
             matrix[i,j] = matrix[i,j-1];
             matrix[i,j-1] = temp;
            }
        }
       }
    }
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
Sort(matrix);
Console.WriteLine ("______________");
PrintMatrix(matrix);