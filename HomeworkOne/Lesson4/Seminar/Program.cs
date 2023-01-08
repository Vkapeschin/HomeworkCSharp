/*
Задача 1. Нахождение количества цифр внутри числа.
*/

/*
int Number (int num)
{
    int i = 1;
    while (num >= 10)
    {
        num = num / 10;
        i++;
    }
    return i;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = Number(a);

Console.Write($"Number {a} consist of following number of digit: {result}");
*/

/*
Задача 2. Нахождение факториала.
*/

/*
int Factorial (int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int output = Factorial (a);
Console.Write($"Factorial number of {a} is {output}");
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i+1}. {array[i]}");
    }
}


Console.Write("Input a size of array: ");
int prSize = Convert.ToInt32(Console.ReadLine());
Console.Write("input min random value: ");
int prminValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int prmaxValue = Convert.ToInt32(Console.ReadLine());

int[] result = CreateRandomArray(prSize, prminValue, prmaxValue);
ShowArray(result); 
