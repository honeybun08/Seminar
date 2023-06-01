// смена первой и последней строки двумерного массива

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)  
{
    int[,] matrix = new int[rows, columns];                              
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)                
    {
        for (int j = 0; j < matrix.GetLength(1); j++)           
        {
            matrix[i,j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j], 5}");  
        }
        Console.WriteLine();
    }
}

// не нужно прохожить по строкам, но по столбцам
void ChangeFirstAndLastRows (int [,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int tmp = matrix [0,j];                            // first row
        matrix [0,j] = matrix[matrix.GetLength(0) - 1, j];  // last row
        matrix[matrix.GetLength(0) - 1, j] = tmp;
    }
}

int [,] array2d = CreateMatrixRndInt(3, 4, -100, 100 );
PrintMatrix(array2d);
Console.WriteLine();
ChangeFirstAndLastRows(array2d);
PrintMatrix(array2d);

