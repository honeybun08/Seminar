Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Максимальное число - первое");
    Console.WriteLine("Минимальное число - второе");
}



if (numberB > numberA)
{
    Console.WriteLine("Максимальное число - второе");
    Console.WriteLine("Минимальное число - первое");
}