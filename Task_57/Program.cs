// частотный словарь

int [,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int [] array = MatrixToArray(array2d);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
Dictionary(array);   // так вызывается метод void





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

int [] MatrixToArray (int [,] matrix)
{                           // size
    int [] arr = new int [matrix.Length];  // новый одномерный массив на основе 2д массива
    int k = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr [k] = matrix[i,j];  //  элементу 1д массива приисваевам элемент из 2д массив(строка, стобуц)
            k++;
        }  
    }   
    return arr;
}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

void Dictionary (int[] arr)
{
    int currentValue = arr[0];   // current value - значение числа
    int count = 1;
    for (int i = 1; i < arr.Length; i++)   // с первого индекса, т.к. нулевой уже взяли
    {
        if (arr[i] == currentValue) count++;   // появился новый элемент
        else 
        { 
            Console.WriteLine($"{currentValue} встречается {count} раз");  // результат одного элемента и сколько раз
            count = 1;   //  возвращаем count к исходному 
            currentValue = arr[i];
        }
    }
    Console.WriteLine($"{currentValue} встречается {count} раз");  // вывод с последним числом
}