// // Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// // запрос данных пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine()??"1");
//     return num;
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// // рекурентно находит натуральные числа 
// // (от первго числа прибавляя 1 до последнего)
// string NaturalNumbers(int m, int n)
// {
//     // точка остановки рекурсии
//     if(m==n) return n.ToString();
//     return ($"{m}, {NaturalNumbers(m+1,n)}");
// }

// int m = ReadData("Введите число M: ");
// int n = ReadData("Введите число N: ");
// string outLine = NaturalNumbers(m,n);

// PrintData("Натуральные числа от M до N: ", outLine);


// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// // запрос данных пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine()??"1");
//     return num;
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// // рекрентно находит сумму натуралных чисел
// int SummNatural(int m, int n)
// {
//     // точка остановки рекурсии
//     if(m==n) return m;
//     return (m+SummNatural(m+1,n));
// }

// int m = ReadData("Введите число M: ");
// int n = ReadData("Введите число N: ");
// int outLine = SummNatural(m,n);

// PrintData("Сумма натуральных элементов от M до N: ", outLine.ToString());


// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// // m = 2, n = 3 -> A(m,n) = 29

// // запрос данных пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine()??"1");
//     return num;
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }
// // вычисления функции Аккермана с помощью рекурсии
// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//     if (m > 0 && n > 0) return Akkerman(m - 1,Akkerman(m,n-1));
//     return Akkerman(m,n); 
// }

// int m = ReadData("Введите положительное число M: ");
// int n = ReadData("Введите положительное число N: ");
// int outLine = Akkerman(m,n);

// PrintData($"Аккерман ({m},{n}) = ", outLine.ToString());