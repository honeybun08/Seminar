Console.WriteLine("Введите значение числа A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение числа B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}