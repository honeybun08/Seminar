Console.WriteLine("Введите число элементов в массиве: ");
int numberM = Convert.ToInt32(Console.ReadLine());

int [] array = FillUserArray(numberM);
PrintArray(array);

int countNums = CountNumbers(array);
Console.WriteLine($"Количество положительных чисел в массиве равно {countNums}");



int[] FillUserArray (int NumberM)
{
    NumberM = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int[NumberM];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите {i + 1} элемент массива"); // проверка каждого из заданных элементов
        arr[i] = Convert.ToInt32(Console.ReadLine());
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

int CountNumbers (int [] arr)
{
    int count = 0;
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i] > 0) 
        {
            i++;
            count++;
        }
    }
    return count;
}
