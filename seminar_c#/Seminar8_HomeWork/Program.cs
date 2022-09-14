//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] OrderLinesArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Начальный массив: ");
int[,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();

Console.WriteLine("Отсортированный массив: ");
int[,] array2 = OrderLinesArray(array);
Show2dArray(array2);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);

if (rows == cols)
    Console.WriteLine("Заданный массив не является прямоугольным"); // Хотя в условии задачи квадратный задан.
else
{
    int SumLineElements(int[,] array, int i)
    {
        int sumLine = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sumLine += array[i, j];
        }
        return sumLine;
    }

    int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int temp = SumLineElements(array, i);
        if (sumLine > temp)
        {
            sumLine = temp;
            minSumLine = i;
        }
    }
    Console.WriteLine($"Строкa {minSumLine + 1} с наименьшей суммой элементов = {sumLine}");
}
*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Мне показалось интересным реализовать любой квадратный массив
/*
Console.Write("Введите длину стороны квадратного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] spiralMatrix = new int[n, n];
Console.WriteLine($"Массив {n} на {n}, заполненный по спирали.");

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0)                  // такой способ придумал,
            Console.Write("0" + array[i, j]  + " ");   // чтобы красиво выводилась матрица.

            else Console.Write(array[i, j]  + " ");
        }
        Console.WriteLine();
    }
}

Show2dArray(spiralMatrix);
*/

