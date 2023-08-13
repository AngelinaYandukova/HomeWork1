// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size]; 
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000); 

    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int EvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
WriteArray(myArray);

int result = EvenNumber(myArray);
Console.WriteLine($"{result}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1); 

    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOddNumbers(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
    return sum;
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);

int result = SumOddNumbers(myArray);
Console.WriteLine($"{result}");
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] EnterNewArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double MaxOfArray(double[] array)
{
    int i = 0;
    double max = array[i];
    for (; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double MinOfArray(double[] array)
{
    int i = 0;
    double min = array[i];
    for (; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] myArray = EnterNewArray(length);
WriteArray(myArray);

double maxNum = MaxOfArray(myArray);
Console.WriteLine($"Max number of array is {maxNum}");
double minNum = MinOfArray(myArray);
Console.WriteLine($"Min number of array is {minNum}");

Console.WriteLine($"The difference between the maximum and the minimum numbers is {maxNum - minNum}.");
*/
