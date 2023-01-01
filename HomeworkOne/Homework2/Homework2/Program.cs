/*
Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

/*
int Method(int num)
{
    int figure = num / 10 % 10;
        return figure;
}

int random = new Random().Next(100, 1000);
int result = Method(random);

Console.WriteLine($"У числа {random} второй цифрой является: {result}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

/*
int Method(int num)
{    
    int result;
    if (num >= 100)
    {
        if (num > 999)
        {
            while (num > 999)
            {
            num = num / 10;
            }
        }
    
        result = num % 10;
    }
    else
    {
        result = -1;
    }
return result;
}
    
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int resultat = Method(number);

if (resultat == -1)
{
    Console.WriteLine($"Третьей цифры в числе {number} нет.");
}
else
{
    Console.WriteLine($"Третья цифра в числе {number}: {resultat}");
}
*/


/*
Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

/*
bool Method(int num)
{
    if (num < 8 && num > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool Method2(int num)
{
    if (num > 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Method(number);

if (result == true)
{
    bool result2 = Method2(number);
    if (result2 == true)
    {
        Console.WriteLine($"{number}-й по счету день недели является выходным днём.");
    }
    else
    {
        Console.WriteLine($"{number}-й по счету день недели является будним днём.");
    }
}
else
{
    Console.WriteLine($"Число {number} не удовлетворяет условиям.");
}
*/