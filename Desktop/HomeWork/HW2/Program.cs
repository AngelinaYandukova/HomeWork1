// Home Work №2
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
/*
int SecondNum(int num)
{
    int newNum = num / 10;
    int findNum = newNum % 10;
    return findNum;
}

Console.Write("Input a three-digit number: ");
int origNum = Convert.ToInt32(Console.ReadLine());

if(origNum > 99 && origNum < 1000)
{
    int res = SecondNum(origNum);
    Console.Write($"The second digit of number {origNum} is {res}.");
}
else Console.WriteLine("This number is not three-digit.");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// ( или -1, если третьей цифры нет).
/*
int ThirdNum(int num)
{
    int res = -1;
    if (num >= 100)
    {
        while(num > 999) num = num / 10;
        res = num % 10;
    }
    return res;
}

Console.Write("Input a number: ");
int origNum = Convert.ToInt32(Console.ReadLine());

int result = ThirdNum(origNum);
if (result == -1) Console.Write($"There is no third digit in the number {origNum}.");
else Console.Write($"The third digit of number {origNum} is {result}.");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Weekday(int num)
{
    if (num >= 1 && num <= 5) return true;
    else return false;
}

bool Days(int number)
{
    if (number > 1 && number < 7) return true;
    else Console.WriteLine("Your number is not in the range from 1 to 7.");
    return false;
}

Console.Write("Input a number from 1 to 7: ");
int yourNumber = Convert.ToInt32(Console.ReadLine());

if (Days(yourNumber))
{
    if (Weekday(yourNumber)) Console.Write($"It's a weekday. =()");
    else Console.Write($"It's a weekend!)");
}
*/