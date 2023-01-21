// Задача 38: Задайте массив чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76


void input_array (int[]array)
{
for (int i=0; i<array.Length;i++)
   array[i] = new Random().Next(-10,11);
}

int diff (int[]array)
{
int diff = 0;
int max = array[0];
int min = array[0];

for (int i=0; i<array.Length;i++) 
{
if (array[i]<min) min = array[i];
if (array[i]>max) max = array[i];  
}
diff = max - min; 
return diff;
}

int [] arr = new int [10];

input_array(arr);
Console.WriteLine($"[{string.Join(", ", arr)}]");
Console.WriteLine ($"Разность между минимальным и максимальным числом в массиве = {diff(arr)}");