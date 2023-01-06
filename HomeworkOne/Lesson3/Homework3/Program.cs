/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num2 = num;
int num3 = num;
int i = 1;
while (num2 >= 10)
{
    num2 = num2 / 10;
    i = i + 1;
}

while (num3 / Math.Pow(10, i - 2) == num3 % Math.Pow(10, i - 2))
{
    num3 = num3 / 10;
    num3 = num3 % Convert.ToInt32(Math.Pow(10, i - 3));
    i = i - 2;
    Console.WriteLine($"{num3 }");
}

Требуется найти решение.

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
