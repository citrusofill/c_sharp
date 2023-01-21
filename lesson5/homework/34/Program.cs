// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void input_array (int[]array)
{
for (int i=0; i<array.Length;i++)
   array[i] = new Random().Next(100,1000);
}

int parity (int[]array)
{
int a = 0;
for (int i=0; i<array.Length;i++)
   {
    if (array[i] % 2 == 0) a++;
   }
   return a;
}

int [] arr = new int [10];

input_array(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine ($"Количество четных чисел: {parity(arr)}");
