int[,] CreateAndFillArray()
{
    Console.Write("Input rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input column: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, column];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max);

    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangeRowsMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max = array[i, 0];
        int min = array[i, 0];
        int indexmax = 0;
        int indexmin = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min >= array[i,j]) 
            {
                min = array[i, j];
                indexmin = j;
                Console.WriteLine($"Сработало min >= [i,j] на шаге {i}, {j}: min = {min} j = {j}");
                ShowArray(array);
            }
            else if (max < array[i, j])
            {
                Console.WriteLine($"Сработало if_max на шаге {i}, {j}");
                ShowArray(array);
                int temp = max;
                max = array[i, j];
                array[i, indexmax] = array[i, j];
                array[i, j] = temp;
                j = 0;
                ShowArray(array);
            }
            else if (min < array[i, j])
            {
                Console.WriteLine($"Сработало if_min на шаге {i}, {j}");
                ShowArray(array);
                int temp2 = min;
                array[i, indexmin] = array[i, j];
                array[i, j] = temp2;
                min = array[0,0];
                j = 0;
                ShowArray(array);
            }

        }
    }
    Console.WriteLine($"Метод отработал");
    return array;
}

int[,] array = CreateAndFillArray();
ShowArray(array);
int[,] array2 = ChangeRowsMaxToMin(array);
ShowArray(array2);
