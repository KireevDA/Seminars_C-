// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int a = 5, b = 7;

if (a > b)
{
    Console.WriteLine("a = max");
}
else
{
    Console.WriteLine("b = max");
}
*/


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int a = 44, b = 5, c = 78;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
int N;

Console.Write("Введите любое число: ");
N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
{
    Console.WriteLine("Четное");
}
else{
    Console.WriteLine("Нечетное");
}
*/


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
int N;
Console.Write("Введите любое число больше 1: ");
N = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < N-1)
{
    i += 2;
    Console.Write(i);
}
*/

