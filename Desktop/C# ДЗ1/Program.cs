// Урок 1. Знакомство с языком программирования С#

// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Unput a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max;

if(num1 > num2) max = num1;
else max = num2;

Console.WriteLine("The maximum number is " + max);
*/

// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Unput a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Unput a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(max < num2) max = num2;
if(max < num3) max = num3;

Console.WriteLine("The maximum number is " + max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Unput a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0) Console.WriteLine($"The number {num} is even.");
else Console.WriteLine($"The number {num} is odd.");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Unput a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= num)
{
    if(current % 2 == 0)
{
    Console.Write(current + " ");
    current++;
}
else current++;
}
*/
