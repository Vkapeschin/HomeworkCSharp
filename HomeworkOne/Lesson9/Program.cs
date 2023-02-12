void NumFromNtoM(int n, int m)
{
    if (n < m)
    {
        Console.Write($"{n} ");
        NumFromNtoM(n + 1, m);
    }
    if (n > m)
    {
        Console.Write($"{n} ");
        NumFromNtoM(n - 1, m);
    }
    if (n == m)
    Console.Write($"{ n}");
}

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

NumFromNtoM(n, m);