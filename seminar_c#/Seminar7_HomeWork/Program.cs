// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandomDoubleArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().NextDouble() * 10;
    return array;
}

void ShowDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandomDoubleArray(m, n);
ShowDoubleArray(array);
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимума: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимума: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");    
        }
    }
}

int[,] SearchElement(int[,] array)
{
  if (n > array.GetLength(0) || m > array.GetLength(1))
  {
    Console.Write("Такой позиции в массиве нет");
  }
  else Console.Write($"Позиция [{n},{m}] -> {array[n-1, m-1]}");

  return array;
}

int[,] Array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(Array);
Console.WriteLine();
SearchElement(Array);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
/*
int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");    
        }
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимума: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимума: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);

for (int j = 0; j < array.GetLength(1); j++) 
{
    double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i,j];
    }
    sum = sum / rows;
    Console.Write(sum + "; ");
}
*/