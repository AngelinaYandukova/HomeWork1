// Home Work №3
// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
/*
void Palindrome(int num)
{
    if (num < 10000 || num > 99999) Console.WriteLine("Uncorrect number!");

    else if (num % 10 == num / 10000 && 
    num % 100 / 10 == num / 1000 % 10)
    Console.WriteLine("This number is a palindrome.");

    else Console.WriteLine("This number isn't a palindrome.");
}

Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    double dist = Math.Sqrt(x*x + y*y + z*z);
    return dist;
}

Console.Write("Input x1: ");
double numx1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double numy1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double numz1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double numx2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double numy2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double numz2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Round(Distance(numx1, numy1, numz1, numx2, numy2, numz2), 2);
Console.WriteLine($"Distance between points ({numx1}, {numy1}, {numz1}) and ({numx2}, {numy2}, {numz2}) is {result}.");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int n)
{
    if (n < 1) Console.WriteLine("Uncorrect number!");
    int current = 1;
    while (current <= n)
    {
        Console.WriteLine($"{current} -> {current * current * current}");
        current++;
    }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Cube(number);
*/