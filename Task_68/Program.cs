// Напишите программу вычисления функции Аккермана
// с помощью рекурсии.
// Даны два неотрицательных числа m и m

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int akkerman = AckRec(numberM, numberN);
Console.WriteLine($"Функция Аккермана равна: {akkerman}");

int AckRec(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckRec(m - 1, 1);
    else return AckRec(m - 1, AckRec(m, n - 1));
}

