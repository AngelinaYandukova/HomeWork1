// Home Work №3
// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

bool Palindrome(int num)
{
    if (num <10000 || num > 99999) break;

    num11 = num % 10;
    num12 = num / 10000;
    num21 = num % 100 / 10;
    num22 = num / 1000 % 10;
    
    if (num11 == num12 && num21 == num22) return true;
}

Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Palindrome(number)) Console.WriteLine("This number is a palindrome.");
else Console.WriteLine("This number isn't a palindrome.");
