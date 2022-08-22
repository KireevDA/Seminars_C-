// Программа, которая принимает на вход одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

int num;
Console.Write("Введите любое число: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num){
    Console.Write(current + " ");
    current++;
}

