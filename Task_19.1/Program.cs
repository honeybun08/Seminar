Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    bool result =  IsPalindrome (number);
    Console.WriteLine(result ? "Да, число является палиндромом" : "Нет, число не является палиндромом");
}


bool IsPalindrome (int num)
{
    int digit1 = num / 10000;
    int digit2 = num / 1000 % 10;
    int digit4 = num % 100 / 10;
    int digit5 = num % 10;
    return digit1 == digit5 && digit2 == digit4 ? true : false;
}
