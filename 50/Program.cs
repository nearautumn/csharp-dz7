// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array, "Созданный массив: ");

int method = GetMethodFromUser();

FindNumberByIndexes(array, method);
// FindIndexesByNumber(array, method);

///////////////////////////////////////////////////////////
int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
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

int GetMethodFromUser() 
{
    link1:
        Console.Write("Для нахождения элемента в массиве по его индексам нажмите 1, для нахождения индексов заданного элемента нажмите 2: ");
        int result = int.Parse(Console.ReadLine() ?? "");
        if (result < 1 || result > 2) goto link1; //отправляет каждый раз на link1 пока пользователь не введет 1 или 2. К сожалению, не знаю как прикрутить такой же переход при вводе нечисленных значений
    return result;
}

void FindNumberByIndexes(int[,] inArray, int mode) 
{
    if (mode != 1) return;
    Console.Write("Введите индекс строки: ");
    int i = int.Parse(Console.ReadLine() ?? "");
    if (i >= inArray.GetLength(0)) 
    {
        Console.WriteLine("Нет такой строки!");
        return;
    }
    Console.Write("Введите индекс столбца: ");
    int j = int.Parse(Console.ReadLine() ?? "");
    if (j >= inArray.GetLength(1)) 
    {
        Console.WriteLine("Нет такого столбца!");
        return;
    }
    Console.WriteLine($"Искомый элемент: {inArray[i,j]}");
}