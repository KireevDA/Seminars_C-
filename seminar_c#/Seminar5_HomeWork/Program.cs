// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Write($"Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine()); 

int[] numbers = new int[N];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(min, max);
  }
}

Console.Write("Получившийся массив: ");

void WriteArray(int[] array)
{
  Console.Write("[ ");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.Write("]");
}

int SumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      sum++;
    }
  }
  return sum;
}

FillArray(numbers, 0, 1000);
WriteArray(numbers);

int sum = SumPositive(numbers);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {sum}");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Write($"Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int N, int min, int max)
{
int[] randomNumbers = new int[N];
int sumElements = 0;

Console.Write("Получившийся массив: ");
Console.Write("[ ");
    for (int i = 0; i < randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 0) // подвох здесь! вроде бы сначала делил с остатком (1), 
                      // но по факту мы складываем четные позиции, которые из-за нуля становятся нечетными.
      {
        sumElements += randomNumbers[i];
      }
      
    }
    Console.Write("]");
    return sumElements;
}

int randomNumbers = RandomNumbers(N, 0, 100);

Console.WriteLine();
Console.Write($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
/*
Console.Write($"Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine()); 

int[] arrayRealNumbers = new int[N];

Console.Write("Получившийся массив: ");

Console.Write("[ ");
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(-100, 100);
    Console.Write(arrayRealNumbers[i] + " ");
  }
Console.Write("]");

int maxNumber = arrayRealNumbers[0];
int minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
      if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

int decision = maxNumber - minNumber;

Console.WriteLine();
Console.WriteLine($"разница между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
*/

