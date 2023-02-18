// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akker (int n, int m)
{
while (n>0)
{
    if (m==0) m=1;
    else m = Akker(n,m-1);
    n--;
}
return m+1;
}

Console.WriteLine ("Введите значения M и N:");
int [] size = Console.ReadLine().Split (" ").Select (x=>int.Parse(x)).ToArray();
Console.WriteLine ($"Функция Аккермана при M={size[0]} и N={size[1]} : {Akker (size[0], size[1])}");
