// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-10, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    System.Console.WriteLine("\n" + "Двумерный массив целых чисел: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] AverageOfCols(int[,] matrix)
{
    double[] resultArray = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        resultArray[i] = Math.Round(sum / matrix.GetLength(0), 2);
    }
    return resultArray;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("\n" + "Среднее арифметическое каждого столбца: " + string.Join("; ", array));
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
double[] myArray = AverageOfCols(myMatrix);
PrintArray(myArray);