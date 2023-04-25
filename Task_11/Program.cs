//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999-> {number}");


int RemoveSecondDigit (int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int neeDigit = firstDigit * 10 + thirdDigit;
    return neeDigit;
}

int result = RemoveSecondDigit(number);
Console.WriteLine($"{number} - > {result}");

