// поэлементное копирование массива

int[] oldArray = CreateArrayRndInt(5,10,20);
PrintArray(oldArray);
Console.WriteLine();
int[] newArray = CopyArray(oldArray);
PrintArray(newArray);

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

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}



int[] CopyArray (int[] arr)
{
    int[] newarray = new int[arr.Length]; // размер = копия исходного размера

    for (int i = 0; i < arr.Length; i++)
    {
        newarray[i] = arr[i];
    }
    return newarray;
}