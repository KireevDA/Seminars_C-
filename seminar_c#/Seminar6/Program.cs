//  Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] ReverseMass(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length -1 -i];
        array[array.Length -1 -i] = temp;
    }
    return array;
}

int[] array = {1, 3, 6, 7, 2, 0};
int[] revMas = ReverseMass(array);
for(int i = 0; i < revMas.Length; i++)
{
    Console.Write(revMas[i] + " ");
}
*/

/*
int[] ReverseMass(int[] array)
{
    int temp = 0;
// цикл for
    // for (int i = 0, j = array.Length -1; i < j; i++; j--)
    // {
    //     temp = array[i];
    //     array[i] = array[j];
    //     array[j] = temp;
    // }
// цикл while
    int i = 0;
    int j = array.Length - 1;

    while(i<j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] =temp;
        i++;
        j--;
    }
    return array;
}

int[] array = {1, 3, 6, 7, 2, 0};
int[] revMas = ReverseMass(array);
for(int i = 0; i < revMas.Length; i++)
{
    Console.Write(revMas[i] + " ");
}
*/


// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 19/2 = 9(1); 9/2 = 4(1); 4/2 = 2(0); 2/2 = 1(0); 1/2 = 0(1)    19 -> 10011
/*
string ChangeDigitSystem(int n)
{
    string result = string.Empty;
    while(n > 0)
    {
        result = n % 2 + result;
        n /= 2;
    }
    return result;
}

Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
string res = ChangeDigitSystem(n);
Console.WriteLine(res);
*/


// задача 1. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольников, каждая сторона треугольника меньше суммы двух других сторон.
/*
void Triangle(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b) Console.WriteLine("Треугольник существует.");
    else Console.WriteLine(" Это не треугольник");
}

Console.WriteLine("Введите длину стороны А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны C: ");
int c = Convert.ToInt32(Console.ReadLine());

Triangle(a, b, c);
*/


// Задача 2. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// ряд Фибоначчи 0 1 1 2 3 5 8 13
/*
int[] Fibonacci(int size)
{
    int[] array = new int [size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i-1] + array[i-2];
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

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibonacci(n));
*/

