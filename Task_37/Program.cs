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

int [] MultiplicationPairNums(int [] arr)
{
    int size = arr.Length/2;
    if(arr.Length % 2 == 1) size +=1;
    int [] newArr = new int [size];
    for (int i = 0; i < arr.Length/2; i++)
    {
        newArr [i] = arr[i] *  arr[arr.Length - 1 -i];
    }
    if(arr.Length % 2 == 1) newArr[newArr.Length -1] = arr[arr.Length / 2];
    return newArr;
}


int [] array = CreateArrayRndInt(5, 1, 10);

Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");

int [] resArr = MultiplicationPairNums(array);

Console.Write("[");
PrintArray(resArr, ",");
Console.WriteLine("]");
