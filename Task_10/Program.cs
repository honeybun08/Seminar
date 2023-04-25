Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());


int result = LeaveSecondDigit(number);
Console.WriteLine($"{number} - > {result}");


int LeaveSecondDigit (int num)
{
    int needDigit = (num / 10) % 10;
    return needDigit;
}



