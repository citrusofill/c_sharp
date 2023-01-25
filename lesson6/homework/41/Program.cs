// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] array = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
int numbersGreaterZero = 0;
foreach (int i in array)
{
    if (i > 0) numbersGreaterZero ++;
}

Console.WriteLine (numbersGreaterZero);