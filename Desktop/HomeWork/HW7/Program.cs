// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] CreateRandom2dArray()
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

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

// double[] AverageColumn(int[,] array)
// {
//     double[] avArray = new double[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             avArray[j] += array[i,j];
//             avArray[j] /= array.GetLength(0);
//         }
//     }
//     return avArray;
// }

void CalculateMean(int[,] array)
{
    // Вычисленное среднее арифметическое по столбцам
    // соберём в массив, который и будем выводить

    float[] meanArray = new float[array.GetLength(1)]; // резервируем память под новый массив
                                                       // количеством столбцов исходного массива
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int r = 0; r < array.GetLength(0); r++)
            meanArray[i] += array[r, i];

        meanArray[i] /= array.GetLength(0);
    }

    for (int i = 0; i < meanArray.Length; i++)
        Console.Write(meanArray[i] + "; ");
}

int[,] myArray = Create2dArray();
Show(myArray);
Console.WriteLine();
CalculateMean(myArray);

// double[] averageAr = AverageColumn(myArray);
// WriteArray(averageAr);

