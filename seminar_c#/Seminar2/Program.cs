// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
/*
int CutNumber(){
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Number is - " + num);
    int dec = num / 100;
    int ed = num % 10;
    int result = dec*10 + ed;
    return result;                             
}

int number = CutNumber();
Console.WriteLine("Cut number is - " + number);
*/

/*
void CutNumber(){
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Number is - " + num);
    int dec = num / 100;
    int ed = num % 10;
    int result = dec*10 + ed;
    Console.WriteLine("Cut number is - " + result);
}
CutNumber();
*/

// 2 факториала перемножить
/*
int Factorial(int num){
    int current = 1;
    int fact = 1;
    while(current <= num){
        fact = fact * current;
        //fact *= current;
        current++;
    }
     return fact;
}

int result = Factorial(12) * Factorial(10);
Console.WriteLine("Your result is - " + result);
*/





