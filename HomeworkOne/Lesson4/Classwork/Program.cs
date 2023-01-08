/*
string[,] table = new string [2, 5];
table [1,2] = "Word";

for (int row = 0; row < 2; row++)
{
    for (int column = 0; column < 5; column++)
    {
        Console.WriteLine($"-{table[row, column]}-");
    }
}
*/


/*
void Method (int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }

        Console.WriteLine("");
    }
}

void FillArray (int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int [3, 4];
Method (matrix);
FillArray (matrix);
Console.WriteLine("");
Method (matrix);
*/

/*
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
    }
}


*/

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci (n-1) + Fibonacci (n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}