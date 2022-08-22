int num;

// Ввод данных
Console.Write("Введите число ");

num = Convert.ToInt32(Console.ReadLine());

// Вычисление квадрата
int square = num * num;

// Вывод ответа на экран
Console.WriteLine("квадрат введенного числа: " + square);

// второй способ решения задачи. Без введения дооплнительной переменной.
// Console.WriteLine("квадрат введенного числа: " + num * num);