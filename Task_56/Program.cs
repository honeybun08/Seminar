// Задайте двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов

int [,] array2d = CreateMatrixRndInt(3, 4, 1, 9 );
PrintMatrix(array2d);
Console.WriteLine();
SumElemInEachRow(array2d);



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


void SumElemInEachRow(int[,] matrix)
{ 
    int minSum = int.MaxValue;       // пусть сумма первой строки - минимальная 
    int minIndex = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)    
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix [i,j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minIndex = i;        // индекс проверяемой строки как минимальный записали, индекс меняется с -1 на 0
        }

    }
   Console.WriteLine($"Номер строки с наименьшей суммой элементов : {minIndex}");
}






 




