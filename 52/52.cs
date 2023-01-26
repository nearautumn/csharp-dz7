// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array, "Созданный массив: ");

FindColumnsAverage(array);

//////////////////////////////////////////////////////////////
int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    Random rnd = new Random();
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            result[i,j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray, string message) 
{
    Console.WriteLine(message);
    for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

FindColumnsAverage(int [,] inArray) 
{
    int sum = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < inArray.GetLength(1); j++) 
    {
        for (int i = 0; i < inArray.GetLength(0); i++) 
        {
            sum += inArray[i,j];
            (double) avg = sum / inArray.GetLength(0);
            Console.Write($"{avg} ")
        }
    }  
}