// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
int Grade(int a, int b)
{
    int res = 1;

    for (int current = 1; current <= b; current++)
       res = res * a; 

    return res;
}

Console.Write("Input number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int result = Grade(numA, numB);
Console.WriteLine($"{numA} в степени {numB} = {result}.");
*/

// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
/*
int Sum(int num)
{
    int sum = 0;
    while (num >= 1)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Input a number:  ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Sum(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {result}.");
*/

// Задача 29: Напишите программу, которая задаёт массив из m 
// элементов и выводит их на экран.

int[] CreateWriteArray(int size)
