// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i = 1; i <= numberB; i++)
  {
    result *= numberA;
  }
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine($"Ответ: {exponentiation}");
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Write("Введите многозначное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int N)
  {    
    int counter = Convert.ToString(N).Length;
    int curr = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      curr = N - N % 10;
      result = result + (N - curr);
      N = N / 10;
    }
   return result;
  }

int sumNumber = SumNumber(N);
Console.WriteLine($"Сумма цифр в числе {N} = {sumNumber}");
*/


//  Напишите программу, которая задаёт массив из произвольных элементов и выводит их на экран.
/*
int size = 20;
int[] array = new int[size];
 
Console.WriteLine("Массив из произвольных элементов");
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(-1000, 1000);
  Console.Write($"{array[i]}. ");
}
*/

