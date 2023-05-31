double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)  
{
    double[,] matrix = new double[rows, columns];                              
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)                
    {
        for (int j = 0; j < matrix.GetLength(1); j++)           
        {
            double num = rnd.NextDouble();        
            matrix[i,j] = Math.Round(num,1);
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
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

double [,] array2d = CreateMatrixRndDouble(3, 4, -10, 25 );
PrintMatrixDouble(array2d);