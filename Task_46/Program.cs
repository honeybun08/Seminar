// задать двумерный массив и вывести его в консоль, размер m * n (m = 3, n = 4)

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)  // Rnd Double      // rows - строки
{
    int[,] matrix = new int[rows, columns];                              //i = index  // по умолчанию заполнен нулями
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)                // 0- строки   // i < rows  // depth для трехмерного и 3 цикла
    {
        for (int j = 0; j < matrix.GetLength(1); j++)           // 1 - столбцы
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)           //  строки, потом столбцы 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");  // 5 - отступ
        }
        Console.WriteLine();
    }
}

int [,] array2d = CreateMatrixRndInt(3, 4, -100, 100 );
PrintMatrix(array2d);


