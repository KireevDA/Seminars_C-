// // две основные функции в массиве ввод и вывод

// Ввод
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

// Вывод
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");       
    }
}
*/

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// ShowArray(CreateRandomArray(size, min, max));


// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
/*
int CountPosEl(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count += array[i];
    }
    return count;
}


int CountNegEl(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count +=array[i];
    }
    return count;
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

int posSum = CountPosEl(array);
int negSum = CountNegEl(array);

Console.WriteLine();
Console.WriteLine($"Sum of positive numbers is {posSum} and sum of negative numbers is {negSum}");
*/


// Задача 1 - Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] ChangeEl(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] *= -1;
    }
    return array;
}

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");       
    }
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);

ShowArray(array);
Console.WriteLine(array);

int[] ArrayResult = ChangeEl(array);
Console.WriteLine();
ShowArray(ArrayResult);
*/

// Задача 2 - Задайте одномерный массив из произвольно кол-ва случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int PosEl(int[] array)

{
    int result = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if(array[index] >= 10 && array[index] <= 99)
            result++;
    }
    return result;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");       
    }
}

Console.WriteLine("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);

ShowArray(array);

int res = PosEl(array);
Console.WriteLine();
Console.WriteLine("Количество элементов массива в промежутке от 10 до 99 равно: " + res);



// Задача 3 - Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
