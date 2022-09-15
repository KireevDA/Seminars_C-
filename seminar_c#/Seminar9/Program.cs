// Рекурсия

// int Sum(int N)
// {
//     if (N >= 5) return N;
//     return N + Sum(N + 1);
// }

// int outNum = Sum(1);
// outNum = 15;


// Задача 63: Задайте значение N. Напишите программу, которая все натуральные числа от 1  до N.
// запрос данных пользователя
/*
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()??"1");
    return num;
}
// рекурсивный вызов числа от 1  до N
string Recurs(int num)
{
    if(num<=1)
    {
        return "1";
    }
    else
    {
        string outLine = RecursOneToN(num-1) + "," + num;
        return outLine;    
    }
    
}

// рекурсивный вызов числа от N  до 1
string Recurs(int num)
{
    if(num<=1)
    {
        return "1";
    }
    else
    {
        string outLine =  num + "," + RecursNToOne(num-1);
        return outLine;    
    }
    
}

// вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

int inputNumber = ReadData("Введите число N:");

string outLine1 = RecursOneToN(inputNumber);

string outLine2 = RecursNToOne(inputNumber);

PrintData("Числа от 1 до N: ", outLine1);
PrintData("Числа от N до 1: ", outLine2);


//Запрос данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

//Рекурсия числа от 1 до N
string RecursOneToN(int num)
{
    if (num <= 1)
    {
        return "1";
    }
    else
    {
        string outLine = RecursOneToN(num - 1) + ", " + num;
        return outLine;
    }
}

//Рекурсия числа от N до 1
string RecursNToOne(int num)
{
    if (num <= 1)
    {
        return "1";
    }
    else
    {
        string outLine = num + ", " + RecursNToOne(num - 1);
    }
}
//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}


int inputNumber = ReadData("Введите число N:");
string outLine1 = RecursOneToN(inputNumber);
string outLine2 = RecursNToOne(inputNumber);
PrintData("Числа от 1 до N: ", outLine1);
PrintData("Числа от N до 1: ", outLine2);
*/


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//Запрос данных от пользователя
/*
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

// решение рекурентно считает сумму чисел
int SumRec(int num)
{
    // точка остановки рекурсии
    if (num <= 0) return 0;
    else
    {
        int sum = 0;
        // рекурентный вызов метода
        sum = num%10 + SumRec(num/10);
        return sum;
    }
}

// решение через While
int SumWhile(int num)
{
    int sum=0;
    while(num>0)
    {
        sum = sum + num%10;
        num = num/10;
    }
    return sum;
}

//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

DateTime d1 = DateTime.Now;

int inputNumber = ReadData("Введите число: ");
int sumDigits1 = SumRec(inputNumber);
PrintData("Время работы рекурсии: ",(DateTime.Now - d1).ToString());

DateTime d2 = DateTime.Now;
int sumDigits2 = SumWhile(inputNumber);
PrintData("Время работы while: ",(DateTime.Now - d2).ToString());

PrintData("Сумма цифр в числе N: ",sumDigits1.ToString());
PrintData("Сумма цифр в числе N: ",sumDigits2.ToString());
*/


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
/*
//Запрос данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

//Рекурентное возведение в степень
long PowRec(int numA, int numB)
{
    //Точка остановки
    if (numB <= 0)
    {
        return 1;
    }
    else
    {
        //Рекурентный вызов
        return numA * PowRec(numA, numB - 1);
    }
}

//Рекурентное возведение в степень с разбиением
long MyPowRec(int numA, int numB)
{
    //Точка остановки
    if (numB == 2)
    {
        return numA * numA;
    }
    //Точка остановки
    if (numB == 1)
    {
        return numA;
    }

    if (numB % 2 == 0)
    {
        return PowRec(numA, numB / 2) * PowRec(numA, numB / 2);
    }
    else
    {
        return PowRec(numA, numB / 2) * PowRec(numA, numB / 2 + 1);
    }
}

//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

int numA = ReadData("Введите число А: ");
int numB = ReadData("Введите число B: ");

DateTime d1 = DateTime.Now;
long resPow1 = PowRec(numA, numB);
PrintData("Время работы PowRec: ", (DateTime.Now - d1).ToString());

DateTime d2 = DateTime.Now;
long resPow2 = MyPowRec(numA, numB);
PrintData("Время работы MyPowRec: ", (DateTime.Now - d2).ToString());

DateTime d3 = DateTime.Now;
long resPow3 = (long)Math.Pow(numA, numB);
PrintData("Время работы Math.Pow: ", (DateTime.Now - d3).ToString());

PrintData("Число " + numA + " в степени " + numB + ":", resPow1.ToString());
PrintData("Число " + numA + " в степени " + numB + ":", resPow2.ToString());
PrintData("Число " + numA + " в степени " + numB + ":", resPow3.ToString());
*/
