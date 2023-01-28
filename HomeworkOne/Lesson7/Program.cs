/*
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
*/
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + "\t");
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
*/

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
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
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