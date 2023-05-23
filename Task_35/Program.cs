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

int CountTwoDigitNums(int [] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       
        if (arr[i] >= min && arr[i] <= max) count +=1;
    }
    return count;
}

int minNum = 10;
int maxNum = 99;
int [] array = CreateArrayRndInt(5, 0, 200);
PrintArray(array, ",");
Console.WriteLine();

int countTwo = CountTwoDigitNums(array, minNum, maxNum);
Console.WriteLine($"В массиве {countTwo} чисел из диапазона [{minNum}, {maxNum}]");
