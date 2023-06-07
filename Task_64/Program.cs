//Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от N до 1.
// 4 -> " 4, 3, 2, 1"
// 2 -> "2, 1"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) NaturalNumbers(number);
else Console.WriteLine("Число не является натуральным");


void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}


