int[,] CreateMatrixRndInt(int rows, int columns)      
{
    int[,] matrix = new int[rows, columns];                           
    
    for (int i = 0; i < matrix.GetLength(0); i++)                
    {
        for (int j = 0; j < matrix.GetLength(1); j++)           
        {
            matrix[i, j] = i + j;   //  matrix[i,j] - это элемент и 2 показателя i, j
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
            Console.Write($"{matrix[i, j], 2}");   // 2 - отступ 
        }
        Console.WriteLine();
    }
}

int [,] array2d = CreateMatrixRndInt(3, 4);
PrintMatrix(array2d);
