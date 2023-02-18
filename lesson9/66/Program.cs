// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Summ (int M, int N)
{
int summa = 0;
if (M<=N) summa = M + Summ (M+1, N);
return (summa);
}

Console.WriteLine ("Введите значения M и N:");
int [] size = Console.ReadLine().Split (" ").Select (x=>int.Parse(x)).ToArray();
int summa = Summ (size[0], size[1]);
Console.WriteLine ($"Cумма числел между M={size[0]} и N={size[1]} : {Summ (size[0], size[1])}");



