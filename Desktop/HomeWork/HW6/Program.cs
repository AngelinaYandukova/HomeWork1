// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int CountPositiveNumber(int m)
{
    int count = 0;
    for(int i = 0; i < m; i++)
    {
        if(Convert.ToInt32(Console.ReadLine()) > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите количество чисел: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int positiveNumber = CountPositiveNumber(numbers);
Console.WriteLine("Количество положительных чисел равно " + positiveNumber);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void PointInsertion (double b1, double k1, double b2, double k2)
{
    if (b1 == b2 && k1 == k2)
        Console.WriteLine("Прямые совпадают.");
    
    else if (b1 != b2 && k1 == k2)
        Console.WriteLine("Прямые параллельны.");

    else
    {   
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых: ({Math.Round(x, 2)}; {Math.Round(y, 2)}).");
    }
}

Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

PointInsertion(b1, k1, b2, k2);
*/
