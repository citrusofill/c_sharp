// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



void input_array (int[]array)
{
for (int i=0; i<array.Length;i++)
   array[i] = new Random().Next(-10,11);
}

int summ (int[]array)
{
int summa = 0;
for (int i=1; i<array.Length;i=i+2) 
      summa = summa + array[i];
return summa;
}

int [] arr = new int [10];

input_array(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine ($"Сумма чисел на нечетных позициях = {summ(arr)}");