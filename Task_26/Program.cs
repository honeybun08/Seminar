//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countNumbers = CountNumbers(number);
Console.WriteLine($"Количесво цифр в числе {number} - {countNumbers}");
int CountNumbers (int num)
{
    int i = 0;
    while (num != 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}
