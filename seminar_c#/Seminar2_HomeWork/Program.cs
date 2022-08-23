// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
Console.WriteLine("вторая цифра этого числа -> " + NumberText[1]);
*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + NumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Да, это выходной день!");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("В неделе 7 дней, уточните свой запрос!");
  }
  else Console.WriteLine("Это рабочий день.");
}

CheckingTheDayOfTheWeek(dayNumber);
*/

