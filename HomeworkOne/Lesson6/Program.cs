/* Задача 1. Можно ли из заданных сторон сделать треугольник.

bool Triangle (double AB, double AC, double BC)
{
    if (AB + BC > AC && AC + BC > AB && AB + AC > BC)
        return true;
    else return false;
}

Console.Write("Введите первую сторону треугольника: ");
double AB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
double AC = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
double BC = Convert.ToDouble(Console.ReadLine());

bool result = Triangle (AB, AC, BC);
if (result == true)
Console.WriteLine($"С данными сторонами можно создать треугольник.");
else
Console.WriteLine($"С данными сторонами создать треугольник нельзя.");
*/

/* Задача 2. Числа Фибонначи в колличестве N при заданных первоначальных числах. 

void Fibonacci(int a, int b, int n)
{
    Console.Write($"{a} {b} ");
    int fibo;
    for (int i = 0; i < n; i++)
    {
        fibo = a + b;
        a = b;
        b = fibo;
        Console.Write($"{fibo} ");
    }
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество чисел Фибоначчи, которыое Вы хотите получить: ");
int n = Convert.ToInt32(Console.ReadLine());


Fibonacci(a, b, n);
*/

/* Задача 3. Коирование массива */

int[] CopyArray (int[] array1)
{
    int[] array2 = new int[array1.Length];
    for (int i = 0; i < array1.Length; i++)
        {
        array2[i] = array1[i];
        }
    return array2;
}
int[] AutoComplete(int size, int min, int max)
{
    int[] array1 = new int[size];
    for (int i = 0; i < size; i++)
    array1[i] = new Random().Next(min, max + 1);
    return array1;
}
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = AutoComplete(size, min, max);
int[] array2 = CopyArray(array1);

ShowArray(array1);
Console.WriteLine("");
ShowArray(array2);