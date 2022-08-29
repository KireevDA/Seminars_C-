// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
void Numbers(int num)
{
    int result = 0;
    for (int curr = 1; curr <= num; curr++)
    {
        result += curr;
        
    }
    Console.WriteLine($"Сумма чисел от 1 до {num} равна {result}");
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);
*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
/*
void Numbers(int num)
{
    int result = 1;
    for(int curr =1; curr < num + 1; curr++)
    {
        result = result * curr;
    }
    Console.WriteLine($"Произведение чисел от 1 до {num} равна {result}");
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Numbers(num);
*/


// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
/*
void Program(int num)
{
    int a = 0;
    if(num == 0) Console.WriteLine("В числе один знак");

    for (int curr = num; curr != 0; curr /= 10)
    {
       a++;
    }
    Console.WriteLine($"Количество цифр в числе равно {a}");
}
 Console.WriteLine("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 Program(number);
*/


//  Напишите программу, которая находит в последовательности от 1 до N все нечетные числа.
/*
void Numbers(int number)
{
    for (int i = 1; i <= number; i += 2)
    {
        Console.Write(i + " ");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);
*/


/*
void Numbers(int number){
    for (int i = 1; i <= number; i += 2){
        Console.Write($"{i} ");
    }
}
Numbers(20);
*/