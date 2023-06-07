// Задайте значения M и N.
// Напишите программу, котрая найдет сумму
// натуральных элементов в промежутке 
// от M до N. Выпольнить с помощью рекурсии.
// M = 1, N = 15, -> 120;
// M = 4, N = 8, -> 30;

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0)
{
    Console.WriteLine(SumRangeRec(numberM, numberN));
}
else Console.WriteLine("Числа не является натуральными");


int SumRangeRec(int m, int n)
{
    if (m == n) return n;
    return m + SumRangeRec(m + 1, n);
}





