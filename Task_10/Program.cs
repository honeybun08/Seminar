Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());


int result = RemoveSecondDigit(number);
Console.WriteLine($"{number} - > {result}");


int RemoveSecondDigit (int num)
{
    int needDigit = (num / 10) % 10;
    return needDigit;
}



