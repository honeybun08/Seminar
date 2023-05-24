int[] CreateArrayRndInt( int size, int min, int max)
{
    int[] arr = new int[size];   //i = index
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}


int GetSumNegativePosElem(int[] arr)
{
    int sum = 0;
    int i = 1;
    while (i < arr.Length)   
    {
        sum += arr[i];
        i = i + 2;
    }
    return sum;
}

int [] array = CreateArrayRndInt(4, 3, 29);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");


int sum = GetSumNegativePosElem(array);
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в массиве равно {sum}");

