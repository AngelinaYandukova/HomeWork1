// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    double min = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a max value: ");
    double max = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows, columns];

    Random random = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = Math.Round(random.NextDouble() * (max - min) + min, 2);

    return array;
}

// Для вывода массива:

void Show(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();
Show(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    Random random = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = random.Next(min, max + 1);

    return array;
}

void Show(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

void Element(int[,] array, int row, int column)
{  

    if (row <= array.GetLength(0) && column <= array.GetLength(1)) 
    Console.WriteLine(array[row, column]);
    else Console.WriteLine("Элемента с такой позицией нет в массиве. ");
}

Console.Write("Input a row: ");
int nrow = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column: ");
int ncolumn = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray();
Show(myArray);
Console.WriteLine();
Element(myArray, nrow, ncolumn);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int [,] Create2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"Введите элемент массива под индексом {i},{j}: ");
            array[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    return array;
}

void Show(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

void AverageColumn(int[,] array)
{   
    float[] avArray = new float[array.GetLength(1)]; 

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int k = 0; k < array.GetLength(0); k++)
            avArray[i] += array[k, i];
            
        avArray[i] /= array.GetLength(0);
    }

    for (int i = 0; i < avArray.Length; i++)
        Console.Write(avArray[i] + "; ");
}

int[,] myArray = Create2dArray();
Show(myArray);
Console.WriteLine();
AverageColumn(myArray);
*/