// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write($"Задайте количество вводимых чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int SumPositive(int[] numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if(numbers[i] > 0 ) count += 1;
  }
  return count;
}

InputNumbers(m);
Console.WriteLine($"Введено чисел больше 0: {SumPositive(numbers)} ");
*/


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write($"Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2) Console.WriteLine("Прямые параллельны.");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
}
*/

