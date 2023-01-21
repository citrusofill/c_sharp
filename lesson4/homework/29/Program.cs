/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
которые вводит пользователь, и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
 
 int [] massive = new int [8];
massive = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine (string.Join (", ", massive));
