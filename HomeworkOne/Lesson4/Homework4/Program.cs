/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

/*
int Method (int a, int b)
{
    for (int i = 1; i < b; i++)
    {
        a = a * a;
    }
    return a;
}

Console.Write("Input a number: ");
int prA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input digit to power of a number: ");
int prB = Convert.ToInt32(Console.ReadLine());

int result = Method(prA, prB);
Console.Write($"{prA} in power of {prB} is {result}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

/*
int Method (int num)
{
    int sum = 0;
    int num2 = num;
    for (int i = 0; num2 > 0; i++)
    {
        num = num2 % 10;
        sum = sum + num;
        num2 = num2 / 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int prNum = Convert.ToInt32(Console.ReadLine());

int result = Method (prNum);
Console.Write($"Sum of digit {prNum} is {result}");
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/

/*
int[] Array (int size)
{
    int[] methArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} number of array: ");
        methArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return methArray;
}

void ShowArray (int[] prArray)
{
    Console.Write("Your array is: ");
    for (int i = 0; i < prArray.Length; i++)
    {
        Console.Write($"{prArray[i]} ");
    }
}

Console.Write("Input size of array: ");
int prSize = Convert.ToInt32(Console.ReadLine());

int[] prArray = Array(prSize);
ShowArray(prArray);
*/