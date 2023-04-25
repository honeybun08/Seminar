Console.WriteLine("Введите цифру");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7) // day of the week or not
{
  bool result = IsWeekend(number);
  Console.WriteLine (result ? "Да" : "Нет");
}

else Console.WriteLine("Неккоректный ввод");

bool IsWeekend (int num) // weekend or not
{
    return num ==6 || num == 7;
}



