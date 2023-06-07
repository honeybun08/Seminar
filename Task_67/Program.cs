// Принимает число, выводит сумму его цифр

Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumRec(number));

int SumRec(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumRec(n / 10);
}             // sec move       // first move

