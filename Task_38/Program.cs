double [] CreateArrayRndDouble (int size, int min, int max)
{
    double [] arr = new double [size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble(); 
        arr[i] = Math.Round(num,1); 
    }
    return arr;
}

void PrintArrayDouble(double [] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
           Console.Write($"{arr[i]}{sep} "); 
        } 
        else Console.Write($"{arr[i]}");
    }
}

double Difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    int i = 1;
    while (i < arr.Length)   
    {
       if (max < arr[i]) max =  arr[i];
       if (min > arr[i]) min =  arr[i];
       i++;
    }
    double diff = max - min;
    return diff;
}

double [] array = CreateArrayRndDouble(5, 3, 78);
Console.Write("[");
PrintArrayDouble(array, ",");
Console.WriteLine("]");

double diff = Difference(array);
double diffRound = Math.Round(diff,1);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {diffRound}");
