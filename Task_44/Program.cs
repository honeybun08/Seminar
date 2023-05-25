Console.WriteLine("Введите число: "); // числа Фибоначчи БЕЗ рекурсии, первые два - 0 и 1 
int number = Convert.ToInt32(Console.ReadLine());

int[] fibonacci = Fibonacci(number);
PrintArray(fibonacci);


int[] Fibonacci(int num)
{
    int[] arr = new int[num];  // создаем массив новый для вывода
    arr[0] = 0; //1 чило
    arr[1] = 1; //2 число
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
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
