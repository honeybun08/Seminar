// невозможно заменить строки на столбцы, если не квадратная матрица(проще через новый массив)

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


int[,] ChangeRowsWithColumns(int[,] matrix)
{
    int[,] newmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];  // массив на основе матрикс
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newmatrix[i, j] = matrix[j, i];  // [i,j]- строка, столбец; [j,i]- столбец, строка
        }
    }
    return newmatrix;
}


int[,] array2d = CreateMatrixRndInt(3, 3, -100, 100);
PrintMatrix(array2d);
Console.WriteLine();

if (array2d.GetLength(0) != array2d.GetLength(1))
{
    Console.WriteLine("Замена строк столбцами невозможна");
    return;
}
int[,] newarray2d = ChangeRowsWithColumns(array2d);
PrintMatrix(newarray2d);

// можно пользовательским вводом и в void указывать обычный исходный массив matrix