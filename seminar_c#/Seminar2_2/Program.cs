// Программа, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру этого числа
/*
int Line(){
    int num = new Random().Next(10, 100);
    Console.WriteLine("Your number is - " + num);
    int dec = num / 10;
    int ed = num % 10;
    if (dec > ed){
        return dec;
    }
    else{
        return ed;
    }
}

Console.WriteLine("Result - " + Line());
*/

// Программа принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/*
void Crat(int num){
    
    if (num % 7 == 0 && num % 23 == 0){
        Console.WriteLine("Число кратно одновременно 7 и 23");
    }
    else{
        Console.WriteLine("Число не кратно одновременно 7 и 23");
    }

}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Crat(number);
*/


//Напишите программу, которая принимает на вход 2 числа и проверяет, является ли одно число квадратом другого.

/*
void Square(int a, int b){
    if(a == b*b || b == a*a){
        Console.WriteLine("Условие выполняется");
    }
    else{
        Console.WriteLine("Условие не выполняется");
    }
}

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Square(a, b);
*/


// напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому
// Если число 2 не кратно числу 1, то программа выводит остаток от деления


int Square(int a, int b){
    
    if(b % a != 0){
        int result = b % a;
        return result;
    }
    else{
        return 0;
    }
}

Console.Write("Enter the number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a==0 || b==0){
    Console.WriteLine("На ноль делить нельзя!");
}
else{
    int result = Square(a,b);
    if(result == 0){
        Console.WriteLine("Второе число кратно первому");
    }
    else{
        Console.WriteLine("Второе число не кратно первому.Остаток от деления: " + result);
    }
}



