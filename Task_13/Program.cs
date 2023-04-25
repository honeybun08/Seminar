Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 1000) // 999 + 1, but we do not take 1000
{
    int result = ShowThirdDigit(number);
    Console.WriteLine($"Третья цифра числа -> {result}");
}
else Console.WriteLine("Третьей цифры нет");

int ShowThirdDigit (int num)
{
    int thirdDigit = num % 10;
    return thirdDigit;
}
