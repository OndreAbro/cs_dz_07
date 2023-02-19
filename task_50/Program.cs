// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GenerateMatrix()
{
    Random rand = new Random();
    int[,] matrix = new int[rand.Next(4, 8), rand.Next(4, 8)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-100, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    System.Console.WriteLine("\n" + "Двумерный массив чисел: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int FindElement(int pos, int[,] matrix)
{
    int m = pos / matrix.GetLength(1);
    int n = pos - m * matrix.GetLength(1);
    return matrix[m, n];
}

var myMatrix = GenerateMatrix();
PrintMatrix(myMatrix);

System.Console.Write("\n" + "Введите позицию элемента: ");
int position = Convert.ToInt32(Console.ReadLine());

string output = (myMatrix.Length <= position || position < 0)
? "Такого элемента нет в данном массиве."
: $"Значение элемента: {FindElement(position, myMatrix)} ";

System.Console.Write(output);