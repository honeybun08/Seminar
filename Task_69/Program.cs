// Чисо А в натуральной степени B

Console.WriteLine("Введите натуральное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SquareRec(numberA, numberB));

int SquareRec(int a, int b)
{
    if (b == 0) return 1;
    return a * SquareRec(a, b - 1);    // степень уменьшается пока не дойдет до 0
}                           //2 параметра

