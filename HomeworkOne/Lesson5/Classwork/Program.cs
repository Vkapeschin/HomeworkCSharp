/*
int[] CreateRandomArray (int arrayLength, int min, int max)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int GetSumOfNegative (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i] < 0)
            sum += array[i];
    }
    return sum;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
}

Console.Write("Input array size: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(arrayLength, min, max);
ShowArray(array);
int sum = GetSumOfNegative(array);
Console.WriteLine("Sum of negative value is: " + sum);
*/

/*Задача 1. Создать массив. Поменять в нем все положительные числа на отрицательные и наоборот.*/

/*
int[] CreateRandomArray(int arrayLength, int minValue, int maxValue)
{
    int[] array = new int[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}

void NegotiveArray(int[] array)
{
    int[] newArray = array;
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = -array[i];
        Console.Write(newArray[i] + " ");
    }
}

Console.Write("Input size of array: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(arrayLength, minValue, maxValue);
ShowArray(array);
NegotiveArray(array);
*/


/*Задача 2. Определить, присутствует ли число в массиве.*/

/*
int[] CreateRandomArray (int arrayLength, int min, int max)
{
    int[] arrayMethod = new int[arrayLength];

    for (int i = 0; i < arrayLength; i++)
        arrayMethod[i] = new Random().Next(min, max + 1);

    return arrayMethod;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine("");
}

bool FindNumber (int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
            return true;
            
    }
    return false;
}

Console.Write("input size of array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a desire number: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(arraySize, min, max);
ShowArray(array);
bool result = FindNumber(array, number);

Console.Write($"Is a desire number been in this array: {result}");
*/

/*Задача 3. В сформированном массиве показать все элементы расположенные в промежутке между "a" и "b". */

/*
int[] CreateRandomArray (int arrayLength, int min, int max)
{
    int[] array = new int[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
}

void ShowNumbersArray (int[] array, int a, int b)
{
    if (a >= b)
    {
        Console.Write($"Numbers from {b} to {a} in this array: ");
        for(int i = 0; i < array.Length; i++)
            if (array[i] >= b && array[i] <= a)
                Console.Write($"{array[i]} ");
    }                
    if (b > a)
    {
        Console.Write($"Numbers from {a} to {b} in this array: ");
        for(int i = 0; i < array.Length; i++)
            if (array[i] >= a && array[i] <= b)
                Console.Write($"{array[i]} ");
    }
}

Console.Write("input size of array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a value of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b value of array: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(arraySize, min, max);
ShowArray(array);
ShowNumbersArray(array, a, b);
*/


