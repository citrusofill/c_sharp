// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void InputMatrix (int [,] matrix)
{
    for (int i = 0; i<matrix.GetLength(0);i++)
    {
        for (int j = 0; j<matrix.GetLength(1);j++)
        {
            matrix[i,j] = new Random().Next (-10,11); //-10, +10
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine ();
    }
}

void FindAverageColumn (int [,] matrix)
{
       for (int j = 0; j<matrix.GetLength(1);j++)
    {
    double summ = 0;
    double averageColumn = 0;
        for (int i = 0; i<matrix.GetLength(0);i++)
        {
            summ = summ + matrix[i,j];
        }
    averageColumn = summ/matrix.GetLength(0);
    Console.WriteLine ($"Среднее арфиметическое столбца: {j} = {averageColumn}");
    }
}



Console.WriteLine ("Введите размер матрицы m x n:");
int [] size = Console.ReadLine().Split (" ").Select (x=>int.Parse(x)).ToArray();
int [,] matrix = new int [size[0],size[1]];
Console.Clear();
InputMatrix(matrix);
FindAverageColumn(matrix);
