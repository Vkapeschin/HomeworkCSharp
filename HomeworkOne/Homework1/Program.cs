//Задача №1. Нахождение большего числа.

/*
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write($"Большим числом является {a}");
}
else
{
    Console.Write($"Большим числом является {b}");
}
*/

//Задача №2. Найти максимальное число. 
//
// Не дает присвоить переменной max значение max = a, т.к. у "а" еще нет значения. Как пофиксить - не нашел)
// Работает с положительными числами.
//
/*
Console.Write("Введите сколько будет чисел для сравнения: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int current = 0;
int a;
int max = 0;

while (current < numbers)
{
    Console.Write("Введите число: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a > max)
    {
        max = a;
    }
    current++;
}

Console.WriteLine($"Максимальное число: {max}");
*/


//Задача №2. Решение для 3х чисел.

/*
Console.WriteLine("Вывод максимального числа из 3х чисел");

Console.Write("Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > a)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"Максимальное число: {max}");
*/

