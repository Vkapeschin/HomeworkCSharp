/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

/*
int Method1 (int num)
{
    int num2 = num;
    int i = 1;
    while (num2 >= 10)
    {
        num2 = num2 / 10;
        i = i + 1;
    }
    return i;
}

bool Method2 (int num, int i)
{
    if (num >= 10)
    {
        while (num / Math.Pow(10, i - 2) == num % Math.Pow(10, i - 2))
        {
            num = num / 10;
            num = num % Convert.ToInt32(Math.Pow(10, i - 3));
            i = i - 2;
            Console.WriteLine($"{num }");
        }
    }
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = Method1(num);
bool result = Method2(num, i);
Console.Write($"Does number {num} is polyndrom: {result}");
*/


/*
Требуется найти решение. Пытался сравнивать первую и последнюю цифры, затем отсекать их от числа и сравнивать следущую пару.
Непонятно, как остановить цикл и как вернуть в основную программу результат.
Ниже написал решение из интернета: сумма всех разрядов у палиндрома в прямой и обратной последовательности будут равны.
*/

/*
bool Method (int num)
{
    int sum = 0;
    int temp = 0;
    int rest = num;
    while (rest >= 1)
    {
        temp = rest % 10;
        sum = sum * 10 + temp;
        rest = rest / 10;
    }

    if (num == sum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input a number: ");
int prNum = Convert.ToInt32(Console.ReadLine());

bool result = Method(prNum);
Console.Write($"Does {prNum} a palindrom {result}");
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double Method (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(xA-xB, 2) + Math.Pow(yA-yB, 2) + Math.Pow(zA-zB, 2)), 2);
    return distance;
}

Console.Write("Укажите x координату точки A: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите y координату точки A: ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите z координату точки A: ");
double zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите x координату точки B: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите y координату точки B: ");
double yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите z координату точки B: ");
double zB = Convert.ToInt32(Console.ReadLine());

double dist = Method(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками равно: {dist}");

*/

/*

Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void Method (int num)
{
    for (int i = 1; i <= num; i++)
    {
        int result = i * i * i;
        Console.Write($"{result} ");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Method(number);

*/
