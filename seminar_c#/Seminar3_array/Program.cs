// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void Function(int a){
    if(a == 1) Console.WriteLine("Значение x>0, y>0");
    else if(a == 2) Console.WriteLine("Значение x<0, y>0");
    else if(a == 3) Console.WriteLine("Значение x<0, y<0");
    else if(a == 4) Console.WriteLine("Значение x>0, y<0");
    else Console.WriteLine("Ввод не соответствует условиям");
}

Console.WriteLine("Введите номер четверти от 1 до 4");
int num = Convert.ToInt32(Console.ReadLine());
Function(num);
*/

// Напишите программу, которая принимаетна вход кординатыточки (x, y) и выдает номер четверти
/*
void Function(int x, int y){
    if(x>0 && y>0) Console.WriteLine("Четверть 1");
    else if(x<0 && y>0) Console.WriteLine("Четверть 2");
    else if(x<0 && y<0) Console.WriteLine("Четверть 3");
    else if(x>0 && y<0) Console.WriteLine("Четверть 4");
}

Console.WriteLine("Введите координаты X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y");
int y = Convert.ToInt32(Console.ReadLine());
if (x==0 || y==0) Console.WriteLine("Несоответствие условию задачи");
else Function(x, y);
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void Square(int a){
    Console.Write(a * a + ", ");
}

Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    Square(i);
    i++;
}
*/

/*
void Square(int n){
    int current = 1;
    while(current<=n){
        Console.Write(current * current + ", ");
        current++;
    }
    
}

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num <=0) Console.Write("Некорректный ввод");
else Square(num);
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// расстояние = корень квадратный ((х2-х1)^2+(y2-y1)^2)

// на пдумать
/*
double average(int x1, int y1, int x2, int y2){
    int s = 
}
*/


Console.WriteLine(Math.Sqrt(25));