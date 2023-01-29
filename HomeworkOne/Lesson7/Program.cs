
int[,] CreateAndFillArray()
{
    Console.Write("Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов в массиве: ");
    int column = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, column];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < column; j++)
            array[i,j] = i + j;
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
int[,] array = CreateAndFillArray();
ShowArray(array);
*/

/*
Задача 2. Найти все элементы массива, у которого оба индекса четные и заменить значения этих элементов на их квадраты.


int[,] CreateRandomArray()
{
    Console.Write("Введите количество строк в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов в массиве: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение в массиве: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение в массиве: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, column];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(min, max + 1);
    return array;
}

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
        for (int j = 0; j < array.GetLength(1); j+=2)
            {
                if (j % 2 == 0 && i % 2 == 0)
                    array[i,j] = array[i,j] * array[i,j];
            }
    return array;
}


int[,] array = CreateRandomArray();
ShowArray(array);
ChangeArray(array);
ShowArray(array);
*/

/* Домашняя работа. 
    Задача 1. Создание массива с заданным размером строк и столбцов.
*/
/*
double[,] CreateArray()
{
    Console.Write("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное вещественное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное вещественное число: ");
    int max = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];

    int a = 0;
    double b = 0;
    for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                a = new Random().Next(min, max);
                b = new Random().NextDouble();
                array[i, j] = Math.Round(a + b, 1);
            }
    return array;
}

double[,] array = CreateArray();
ShowArray(array);
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/
/*
void ShowElementOfArray(int[,] array)
{
    Console.Write("Введите номер строки: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int j = Convert.ToInt32(Console.ReadLine());

    if (i < array.GetLength(0) && j < array.GetLength(1))
        Console.WriteLine($"Значение элемента массива: {array[i - 1,j - 1]}");
    else Console.Write("Данного элемента массива не существует.");
}

int[,] array = CreateAndFillArray();
ShowArray(array);
ShowElementOfArray(array);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
void AvarageColumn(int[,] array)
{
    double sum = 0;
    double avarage = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum += array[i,j];
                    avarage = sum / array.GetLength(0);
                }
            Console.Write($"{avarage}\t");
            sum = 0;
            avarage = 0;
        }
}    

int[,] array = CreateAndFillArray();
ShowArray(array);
AvarageColumn(array);
*/