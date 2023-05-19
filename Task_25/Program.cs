Console.WriteLine("Введите число - A: ");
int a= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральную степень для числа - B: ");
int b= Convert.ToInt32(Console.ReadLine());

if (b < 1) Console.WriteLine("Введен НЕВЕРНЫЙ показатель степени");
else
{
    int degree = Degree(a, b);
    Console.WriteLine($"Преобразование числа {a} в степень {b} равно {degree}");
}

int Degree (int A, int B)
{
    int c = 1;
    while (B != 0)
    {
        c = c * A;
        B= B - 1;
    }
    return c;
}