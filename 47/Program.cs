//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");

double[,] array = GetDoubleArray(rows, columns, 20);
PrintArray(array, "Полученный массив");

/////////////////////////////////////////////////////////////
double[,] GetDoubleArray(int m, int n, int scale) 
{
    double[,] result = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            result[i,j] = rnd.NextDouble() * scale;
        }
    }
    return result;
}

void PrintArray(double[,] inArray, string message) 
{
    Console.WriteLine(message);
    for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            Console.Write($"{Math.Round(inArray[i,j], 1)} ");
        }
        Console.WriteLine();
    }
}