// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}

int[,] result = GetArray(rows, columns);
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i, m] + "\t");
        }
        Console.WriteLine();
    }
}
PrintArray(result);

int[,] arithmeticMeanMatrix = GetArray(rows, columns);
for (int i = 0; i < rows; i++)
{
    double arithmeticMean = 0;
    //int summ = 0;
    for (int k = 0; k < columns; k++)
    {
        // summ += arithmeticMeanMatrix[i, k];
        // arithmeticMean = summ / columns;
        arithmeticMean += arithmeticMeanMatrix[i, k];
    }
    arithmeticMean = Math.Round(arithmeticMean / columns, 1);
    Console.WriteLine($"Среднее арифметическое столбца № {i + 1} = {arithmeticMean}");
}



