Console.WriteLine("Введите положительнео число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countNumbers = CountNumbers(number);
Console.WriteLine($"Количесво цифр в числе {number} - {countNumbers}");


int CountNumbers (int num)
{
    int i = 0;
    while (num > 0)
    {
        i =  i + num % 10;
        num = num / 10;
    }
    return i;
}

