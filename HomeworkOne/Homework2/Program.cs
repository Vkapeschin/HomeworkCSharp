/*
int CutNumber(int num)
{
    int sot = num / 100;
    int ed = num % 10;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100,1000);

int newNum = CutNumber(randNum);

Console.WriteLine($"New version of number {randNum} is {newNum}");
*/

//Задача 1. Сравнить две цифры в случайном числе. Выдать большее.
//Задача 2. Сравнить два числа. Указать - является ли второе число кратным первому.
//Задача 3. Одно число. Кратно ли оно числам "a" и "b".

//Задача 1.
/*
int numbers(int num)
{
    int first = num / 10;
    int second = num % 10;

    int max = first;
    if (max < second)
    {
        max = second;
    }

    return max;
}

int random = new Random().Next(10,100);
int result = numbers(random);

Console.WriteLine($"Большее из двух цифр числа {random} является {result}");

*/
//Задача 2.
/*
bool method(int a, int b)
{
    double c = b % a;
    if (c == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите первое число: ");
int randomnumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int randomnumber2 = Convert.ToInt32(Console.ReadLine());

bool bools = method(randomnumber1, randomnumber2);

Console.WriteLine($"Второе число является кратным первому: {bools}");
*/

//Задача №3.
/*
bool method(int a, int b, int c)
{
    if (a % b == 0 && a % c ==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите проверяемое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое проверяющее число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе проверяющее число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

bool result = method(n1, n2, n3);

Console.WriteLine(result);
*/