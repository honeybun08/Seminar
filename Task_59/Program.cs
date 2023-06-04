// удалить строку и столбец, на ересечении которых находится наименьший элемент массива 

int[,] array2d = CreateMatrixRndInt(3, 4, 5, 37);
PrintMatrix(array2d);
int[] minElemIndexes = MinElemIndexes(array2d);
Console.WriteLine(minElemIndexes[2]);  // т.к. первый индекс взяли
Console.WriteLine();
int [,] deleteRowCol = DeleteRowCol(array2d, minElemIndexes[0], minElemIndexes[1]);
PrintMatrix(deleteRowCol);

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

int[] MinElemIndexes(int[,] matr)
{
    int min = matr[0, 0];  // начальный индекс 1го элемента
    int row = 0;
    int column = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];   // поиск минимльного элемента и проход по другим индексам(объяснение i и j)
                row = i;
                column = j;
            }

        }
    }
    return new int[] {row, column, min};
}

int[,] DeleteRowCol(int[,] matr, int delRow, int delCol)
{
    int[,] newMatrix = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];  // размер на 1 строку и столбец меньше исходного
    int m = 0;                                                // счетчики старого массива
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == delRow) m++;
        for (int j = 0; j < newMatrix.GetLength(0); j++)                    // проходим по новому массиву 2д
        {
            if (n == delCol) n++;
            newMatrix[i, j] = matr[m, n];                                           // замена счетчиков нового и старого
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}