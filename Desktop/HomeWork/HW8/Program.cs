// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
        
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
SortArray(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
        
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();

int SumOfRow(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
    }
    return sum;
}

int sum = SumOfRow(myArray);
int rowWithMinSum = 1;

for (int i = 0; i < myArray.GetLength(0); i++)
{
    if (sum > SumOfRow(myArray))
    {
        sum = SumOfRow(myArray);
        rowWithMinSum ++;
    }
}
Console.WriteLine($"The row with the smallest sum of elements is {rowWithMinSum}.");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
        
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

int[,] myArray1 = CreateRandom2dArray();
Show2dArray(myArray1);
Console.WriteLine();
int[,] myArray2 = CreateRandom2dArray();
Show2dArray(myArray2);
Console.WriteLine();

if (myArray1.GetLength(1) != myArray2.GetLength(0))
    Console.WriteLine("The number of columns of the first matrix must match the number of rows of the second matrix.");

int[,] ProductOfMatrices(int[,] array1, int[,] array2)
{   
    int[,] prodOfMatr = new int[myArray1.GetLength(0), myArray2.GetLength(1)];
       
    for (int i = 0; i < myArray1.GetLength(0); i++)
    {
        for (int j = 0; j < myArray2.GetLength(1); j++)
        {
            for (int k = 0; k < myArray1.GetLength(1); k++)
            {
                prodOfMatr[i, j] += myArray1[i, k] * myArray2[k, j];
            }
        }
    }
    return prodOfMatr;
}


int[,] result = ProductOfMatrices(myArray1, myArray2);
Show2dArray(result);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
