/*
// метод заполнения двумерного массива
int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

// метод вывода двумерного массива
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

// метод запроса данных у пользователя
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимума: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимума: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows, cols, min, max); // создаем новую переменную массив равный рандомному
Show2dArray(array); // вызываем метод, котрый покажет наш массив
*/

// задача 3. Найти сумму элементов стоящих на главной диагонали матрицы (0,0; 1,1; 2,2; ... 9,9;)
/*
// метод заполнения двумерного массива
int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

// метод вывода двумерного массива
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

// метод решения 1: через функцию 

// int CalcSumDiag(int[,] array)
// {
//     int sum = 0;
//     if(array.GetLength(0) == array.GetLength(1))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if(i == j) sum += array[i, j];        
//             }    
//         }
//     }
//     return sum;
// }

// метод решения 2: через функцию int
int CalcSumDiag(int[,] array)
{
    int sum = 0;
    if(array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, i];  
        }
    }
    return sum;
}

// метод запроса данных у пользователя
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимума: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимума: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows, cols, min, max); // создаем новую переменную массив равный рандомному
Show2dArray(array); // вызываем метод, котрый покажет наш массив
int sum = CalcSumDiag(array);
Console.Write("Сумма чисел главной диагонали равна: " + sum);
*/

// Задача 48: Задайте двумерный массив размера M x N, каждый элемент в массиве находится по формуле: A = m+n. Выведите полученный массив на экран.
/*
int[,] CreateRandom2dArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i,j] = i + j;
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
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, m); // создаем новую переменную массив равный рандомному
Show2dArray(array); // вызываем метод, котрый покажет наш массив
*/

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты.
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

int[,] Calculate(int[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(i%2 == 0 && j%2 == 0)
                array[i, j] *= array[i, j];        
            }    
        }
    return array;
}
// второе решение задается шаг +2
int[,] Calculate(int[,] array)
{
        for (int i = 0; i < array.GetLength(0); i+=2)
        {
            for (int j = 0; j < array.GetLength(1); j+=2)
            {
                // if(i%2 == 0 && j%2 == 0)
                array[i, j] *= array[i, j];        
            }    
        }
    return array;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимума: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимума: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows, cols, min, max); // создаем новую переменную массив равный рандомному
Show2dArray(array); // вызываем метод, который покажет наш массив
Calculate(array);
Console.WriteLine();
Show2dArray(array);
*/


// Дан двумерный массивю Поменять местами:
// а) элементы, расположенные в правом верхнем и левом нижнем углах;
// б) элементы, расположенные в правом нижнем и левом верхнем углах.
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

int[,] Calculate(int[,] array)
{
    int temp = 0;
    temp = array[0, array.GetLength(1)-1];
    array[0, array.GetLength(1)-1] = array[array.GetLength(0)-1, 0];
    array[array.GetLength(0)-1, 0] = temp;

    temp = array[array.GetLength(0)-1, array.GetLength(1)-1];
    array[array.GetLength(0)-1, array.GetLength(1)-1] = array[0, 0];
    array[0, 0] = temp;

    return array;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение минимума: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение максимума: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows, cols, min, max); // создаем новую переменную массив равный рандомному
Show2dArray(array); // вызываем метод, котрый покажет наш массив
Calculate(array);
Console.WriteLine();
Show2dArray(array);
*/

