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

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
int[,] Reverse2dArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
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

int[,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();

if (array.GetLength(0) == array.GetLength(1))
{
    int[,] array2 = Reverse2dArray(array);
    Show2dArray(array2);
}
else
{
    Console.WriteLine("Matrix not square!");
}
*/

//Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит (заменить элементы на 0) строку и столбец, на пересечении которых расположен наименьший элемент массива.
/*
int[,] Change2dArray(int[,] array)
{
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[iMin, j] = 0;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, jMin] = 0;
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

int[,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();
int[,] array2 = Change2dArray(array);
Show2dArray(array2);
*/

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строки массива.

int[,] ChangeRows(int[,] array)
{
    // решение по столбцам
    int temp = 0;
    int i = array.GetLength(0) - 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[0, j];
        array[0, j] = array[i, j];
        array[i, j] = temp;
    }
    // // решение по строкам
    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     int temp = array[array.GetLength(1) - 1, i];
    //     array[array.GetLength(1) - 1, i] = array[0, i];
    //     array[0, i] = temp;
    // }
    return array;
}

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(4, 4, 0, 9); // CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();

int[,] array2 = ChangeRows(array);
Show2dArray(array2);
