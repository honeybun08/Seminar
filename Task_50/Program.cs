Console.WriteLine("Введите первую позицию элемента в двумерном массиве: ");
int pos1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую позицию элемента в двумерном массиве: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

int [,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
bool IsElementExist = isElementExist(array2d, pos1, pos2);
Console.WriteLine (IsElementExist ?  "Такой элемент есть в массиве" : "Такого элемента нет в массиве");


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

bool isElementExist(int [,] matr, int position1, int position2)
{
    if (position1 < matr.GetLength(0) && position2 < matr.GetLength(1))  
    return true;
    else return false;
}



