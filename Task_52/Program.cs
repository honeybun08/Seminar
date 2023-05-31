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


double [] Average (int [,] matr)
{
    double[] arr = new double [matr.GetLength(1)];   
    
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;                      
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];           
        }
        arr[j] = Math.Round(sum / matr.GetLength(0), 1);  
    }
    return arr;   
}

void PrintArrayDouble(double [] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
           Console.Write($"{arr[i]}{sep} "); 
        } 
        else Console.Write($"{arr[i]}");
    }
}




int [,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);

double [] average = Average(array2d);

PrintArrayDouble(average, ";");
Console.WriteLine(" ");





