// Задайте две матрицы. Напиште программу, которая будет находить произведение двух матриц
// Условия:
// 1) Умножение матриц осуществляется путем умножения строки на столбец.
// 2) Находятся произведения первого элемента строки и первого элемента столбца, 
// 3) второго элемента строки и второго элемента столбца и т.д. Затем полученные произведения суммируются. 
// 4) Каждую строку из firstMatrix нужно умножить на каждый столбeц secondMatrix




Console.WriteLine("Введите число строк первой матрицы");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой матрицы");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве первой матрицы");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве первой матрицы");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = CreateMatrixRndInt(rows2, columns2, minimum, maximum);
PrintMatrix(firstMatrix);

Console.WriteLine();

Console.WriteLine("Введите число строк второй матрицы");
int rows3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы");
int columns3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число в массиве второй матрицы");
int minimum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве второй матрицы");
int maximum1 = Convert.ToInt32(Console.ReadLine());

int[,] secondMatrix = CreateMatrixRndInt(rows3, columns3, minimum1, maximum1);
PrintMatrix(secondMatrix);
                                                     //индексы       i   j          j    k
int[,] finalMatrix = new int[rows2, columns3];        //матрица      m x n и матрица n x k, матрица - m x k

MultiplyMatrix(firstMatrix, secondMatrix, finalMatrix);
Console.WriteLine($"Произведение двух матриц: ");
PrintMatrix(finalMatrix);
 
 
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}
                                                        

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] finalMatrix)
{
    for (int i = 0; i < finalMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < finalMatrix.GetLength(1); j++)
        {
            int multiplictionRes = 0;                                    //обнуление
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                multiplictionRes += firstMartrix[i, k] * secomdMartrix[k, j];   // если число столбцов firstMatrix равно числу строк secondMatrix
            }
            finalMatrix[i,j] = multiplictionRes;
        }
    }
}

