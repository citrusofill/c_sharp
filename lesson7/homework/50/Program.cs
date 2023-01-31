// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void FindNumber (int [,] matrix, int[]position)
{
if ((position[0]<= matrix.GetLength(0)) && (position[1]<= matrix.GetLength(1)))
{
    Console.WriteLine ($"На позиции {position[0]}, {position[1]}: {matrix [position[0],position[1]]}");
    return;
}
Console.WriteLine("Такой позиции в матрице нет.");
}



Console.WriteLine ("Введите размер матрицы m x n:");
int [] size = Console.ReadLine().Split (" ").Select (x=>int.Parse(x)).ToArray();
int [,] matrix = new int [size[0],size[1]];
Console.Clear();
InputMatrix(matrix);

Console.WriteLine ("Введите позицию элемента в матрице m,n:");
int [] position = Console.ReadLine().Split (" ").Select (x=>int.Parse(x)).ToArray();
FindNumber(matrix,position);
