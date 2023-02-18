// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



void InputMatrix (int [,] matrix)
{
   int x = 0;
   int y = 0;
   int xStart = 0;
   int xEnd = matrix.GetLength(0)-1;
   int yStart = 0;
   int yEnd = matrix.GetLength(1)-1;
   int i=1;

    while (i<(matrix.GetLength(0)*matrix.GetLength(1)))
    {
        for (y = yStart; y<=yEnd; y++)
        {
            matrix[xStart,y]=i;
            i++;
        }
        xStart++;

        for (x = xStart; x<=xEnd; x++)
        {
            matrix[x,yEnd]=i;
            i++;
        }
        yEnd--;

        for (y = yEnd; y>=yStart; y--)
        {
            matrix[xEnd,y]=i;
            i++;
        }
        xEnd--;

        for (x = xEnd; x>=xStart; x--)
        {
            matrix[x,yStart]=i;
            i++;
        }
        yStart++;
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

Console.WriteLine ("Введите размер матриц m x n:");
int [] size = Console.ReadLine().Split (" ").Select (x=>int.Parse(x)).ToArray();
int [,] matrix = new int [size[0],size[1]];
Console.Clear();
InputMatrix(matrix);
PrintMatrix(matrix);
