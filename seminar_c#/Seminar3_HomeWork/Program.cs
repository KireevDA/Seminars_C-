// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Введите пятизначное число: ");
int NumberText = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(NumberText);

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine("Ваше число является палиндромом.");
  }
  else Console.WriteLine("Ваше число не является палиндромом.");
}

if (number.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine("Ваше число не пятизначное");
*/


//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube (int a)
{
    Console.Write(a*a*a + ", ");
}

Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    Cube(i);
    i++;
}
*/


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
int x1 = Coordinate("x", "1");
int y1 = Coordinate("y", "1");
int z1 = Coordinate("z", "1");
int x2 = Coordinate("x", "2");
int y2 = Coordinate("y", "2");
int z2 = Coordinate("z", "2");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Длина отрезка  {segmentLength}");
*/


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
/*
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}
double Decision(double x1, double x2, double y1, double y2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
}

Console.WriteLine($"Длина отрезка  {Convert.ToInt32(Decision(x1, x2, y1, y2))}  "); 
*/
