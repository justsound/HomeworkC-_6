Console.Clear();

// Показать двумерный массив размером m×n заполненный вещественными числами

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintDoubleMassive(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CreateDoubleMassive(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rnd = new Random();
            matr[i, j] = Math.Round(rnd.Next(-100, 100) + rnd.NextDouble(), 2);
        }
    }
}

/* int n = ReadInt("Введите количество строк n: ");
int m = ReadInt("Введите количество столбцов m: ");
double[,] matrix = new double[n, m];
CreateDoubleMassive(matrix);
PrintDoubleMassive(matrix); */

//Задать двумерный массив следующим правилом: Aₘₙ = m+n

void CreateMassive2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
}

void PrintMassive(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

/* int n = ReadInt("Введите количество строк n: ");
int m = ReadInt("Введите количество столбцов m: ");
int[,] matrix = new int[n, m];
CreateMassive2(matrix);
PrintMassive(matrix);

 */

// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void CreateMassive(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
}

int n = ReadInt("Введите количество строк n: ");
int m = ReadInt("Введите количество столбцов m: ");
int[,] matrix = new int[n, m];
CreateMassive(matrix);
PrintMassive(matrix);
Console.WriteLine("Измененный массив:");

void CreateChangeMassive(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < matr.GetLength(1); j = j + 2)
        {
            matr[i, j] = matr[i, j] * matr[i, j];
        }
    }
}
/* CreateChangeMassive(matrix);
PrintMassive(matrix); */

// Написать программу, которая обменивает элементы первой строки и последней строки

void ChangeMassive(int[,] matr)
{
    for (int i = 0; i < m; i ++) 
    {
        int tmp = matr[0,i];
        matr[0,i] = matr[n-1,i];
        matr[n-1,i] = tmp;
    }
}

ChangeMassive(matrix);
PrintMassive(matrix);
